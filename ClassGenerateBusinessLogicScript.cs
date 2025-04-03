using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator
{
    public static class ClassGenerateBusinessLogicScript
    {
        public static string BusinessLogicScript(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"\nusing System;\nusing System.Data;\npublic class Class{dt.TableName}\n");
            script.Append("\n{\n");
            script.Append(Members(dt));
            script.Append(Constructors(dt));
            script.Append(Methods(dt));
            script.Append("\n}");
            return script.ToString();
        }

        public static string Members(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append("    public enum enMode { AddNew = 0, Update = 1 };\n    public enMode Mode = enMode.AddNew;\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                script.Append($"    public {ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]} {"{ get; set; }"}\n");
            }
            return script.ToString();
        }

        public static string Constructors(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"\n    public Class{dt.TableName}()\n{"    {"}\n        Mode = enMode.AddNew;\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                script.Append($"        this.{dr["Column Name"]} = {ClassGlobal.GetInitializeValue(dr["Data Type"].ToString())};\n");
            }
            script.Append("    }\n");

            script.Append($"\n    public Class{dt.TableName}(");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]})\n    {"{\n"}");
                else
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}, ");
            }
            script.Append("        Mode = enMode.Update;\n");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                script.Append($"        this.{dr["Column Name"]} = {dr["Column Name"]};\n");
            }

            script.Append("    }\n");
            return script.ToString();
        }

        public static string Methods(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"\n    public static DataTable GetAll{dt.TableName}() " + "{ " + $"return Class{dt.TableName}Data.GetAll{dt.TableName}();" + "}\n");
            script.Append("\n" + AddNewMethod(dt));
            script.Append("\n" + UpdateMethod(dt));
            script.Append("\n    public bool Save()\n    {\n        switch (Mode)\n        {\n            case enMode.AddNew:\n                if (_AddNew())\n                {\n                    Mode = enMode.Update;\n                    return true;\n                }\n                else\n                    return false;\n            case enMode.Update:\n                return _Update();\n        }\n        return false;\n    }\n");
            script.Append($"\n    public bool Delete{dt.TableName}ByID(int ID) " + "{ " + $"return Class{dt.TableName}Data.Delete{dt.TableName}ByID(ID);" + "}\n");
            return script.ToString();
        }

        public static string AddNewMethod(DataTable dt)       
        { 
            StringBuilder script = new StringBuilder();
            DataRow firstDR = dt.Rows[0];
            script.Append($"    private bool _AddNew()\n    {"{\n"}        this.{firstDR["Column Name"]} = Class{dt.TableName}Data.AddNew{dt.TableName}(");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"this.{dr["Column Name"]});\n");
                else
                    script.Append($"this.{dr["Column Name"]}, ");
            }
            script.Append($"        return (this.{firstDR["Column Name"]} != -1);\n    {"}\n"}");
            return script.ToString();
        }

        public static string UpdateMethod(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            DataRow firstDR = dt.Rows[0];
            script.Append($"    private bool _Update() {"{"}  return Class{dt.TableName}Data.Update{dt.TableName}(");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"this.{dr["Column Name"]});\n");
                else
                    script.Append($"this.{dr["Column Name"]}, ");
            }
            return script.ToString();
        }
    }
}
