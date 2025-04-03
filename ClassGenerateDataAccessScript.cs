using System;
using System.Data;
using System.Text;

namespace Code_Generator
{
    public static class ClassGenerateDataAccessScript
    {
        public static string DataAccessScript(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"using System;\nusing System.Data;\nusing System.Data.SqlClient;\n\npublic class Class{dt.TableName}Data\n");
            script.Append("\n{");
            script.Append(GetAll(dt));
            script.Append(GetByID(dt));
            script.Append(AddNew(dt));
            script.Append(Update(dt));
            script.Append(DeleteByID(dt));
            script.Append("\n}");
            return script.ToString();
        }

        private static string GetAll(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"\n        public static DataTable GetAll{dt.TableName}()\n");
            script.Append("        {\n");
            script.Append("        string query = \"EXEC SP_GetAll" + dt.TableName + "\";\n");
            script.Append("        DataTable dt = new DataTable();\n");
            script.Append("        SqlConnection connection = new SqlConnection(ClassSettingsData.ConnectionString);\n");
            script.Append("        SqlCommand command = new SqlCommand(query, connection);\n");
            script.Append("        try\n        {\n");
            script.Append("            connection.Open();\n");
            script.Append("            SqlDataReader reader = command.ExecuteReader();\n");
            script.Append("            if (reader.HasRows)\n");
            script.Append("                 dt.Load(reader);\n");
            script.Append("            reader.Close();\n");
            script.Append("        }\n");
            script.Append("        catch {}\n");
            script.Append("        finally { connection.Close(); }\n");
            script.Append("        return dt;\n    }\n");
            return script.ToString();
        }

        private static string GetByID(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            DataRow firstDR = dt.Rows[0];
            script.Append($"\n    public static bool Get{dt.TableName}ByID(int {firstDR["Column Name"]}, ");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"ref {ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}");
                else
                    script.Append($"ref {ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}, ");
            }
            script.Append(")\n    {\n");
            script.Append($"        string query = \"EXEC SP_Get{dt.TableName}ByID @{firstDR["Column Name"]} = {firstDR["Column Name"]}\";\n");
            script.Append("        bool isFound = false;\n");
            script.Append("        SqlConnection connection = new SqlConnection(ClassSettingsData.ConnectionString);\n");
            script.Append("        SqlCommand command = new SqlCommand(query, connection);\n");
            script.Append("        try\n");
            script.Append("        {\n");
            script.Append("            connection.Open();\n");
            script.Append("            SqlDataReader reader = command.ExecuteReader();\n");
            script.Append("            if (reader.Read())\n");
            script.Append("            {\n");
            script.Append("                isFound = true;\n");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                script.Append($"                {dr["Column Name"]} = ({ClassGlobal.GetTypeOf(dr["Data Type"].ToString())})reader[\"{dr["Column Name"]}\"];\n");
            }
            script.Append("            }\n");
            script.Append("            else\n");
            script.Append("            {\n");
            script.Append("            isFound = false;\n");
            script.Append("            reader.Close();\n");
            script.Append("            }\n");
            script.Append("        }\n");
            script.Append("        catch { isFound = false; }\n");
            script.Append("        finally { connection.Close(); }\n");
            script.Append("        return isFound;\n    }\n");
            return script.ToString();
        }

        private static string AddNew(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            script.Append($"\n    public static int AddNew{dt.TableName} (");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}");
                else
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}, ");
            }
            script.Append(")\n    {\n");
            script.Append($"        string query = $\"EXEC SP_AddNew{dt.TableName} ");
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    if (ClassGlobal.GetTypeOf(dr["Data Type"].ToString()) == "string")
                        script.Append("@" + dr["Column Name"] + " = '{" + dr["Column Name"] + "}'");
                    else
                        script.Append("@" + dr["Column Name"] + " = {" + dr["Column Name"] + "}");
                else
                    if (ClassGlobal.GetTypeOf(dr["Data Type"].ToString()) == "string")
                    script.Append("@" + dr["Column Name"] + " = '{" + dr["Column Name"] + "}', ");
                else
                    script.Append("@" + dr["Column Name"] + " = {" + dr["Column Name"] + "}, ");

            }
            script.Append("\";\n");
            script.Append("        int ID = -1;\n");
            script.Append("        SqlConnection connection = new SqlConnection(ClassSettingsData.ConnectionString);\n");
            script.Append("        SqlCommand command = new SqlCommand(query, connection);\n");
            script.Append("        try\n");
            script.Append("        {\n");
            script.Append("            connection.Open();\n");
            script.Append("            object result = command.ExecuteScalar();\n");
            script.Append("            if (result != null && int.TryParse(result.ToString(), out int insertedID))\n");
            script.Append("                ID = insertedID;\n");
            script.Append("        }\n");
            script.Append("        catch {}\n");
            script.Append("        finally { connection.Close(); }\n");
            script.Append("        return ID;\n    }\n");
            return script.ToString();
        }

        private static string Update(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            DataRow firstDR = dt.Rows[0];
            script.Append($"\n    public static bool Update{dt.TableName} (");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}");
                else
                    script.Append($"{ClassGlobal.GetTypeOf(dr["Data Type"].ToString())} {dr["Column Name"]}, ");
            }
            script.Append(")\n    {\n");
            script.Append($"        string query = $\"EXEC SP_Update{dt.TableName} ");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    if (ClassGlobal.GetTypeOf(dr["Data Type"].ToString()) == "string")
                        script.Append("@" + dr["Column Name"] + " = '{" + dr["Column Name"] + "}'");
                    else
                        script.Append("@" + dr["Column Name"] + " = {" + dr["Column Name"] + "}");
                else
                    if (ClassGlobal.GetTypeOf(dr["Data Type"].ToString()) == "string")
                    script.Append("@" + dr["Column Name"] + " = '{" + dr["Column Name"] + "}', ");
                else
                    script.Append("@" + dr["Column Name"] + " = {" + dr["Column Name"] + "}, ");
            }
            script.Append("\";\n");
            script.Append("        int rowsAffected = 0;\n");
            script.Append("        SqlConnection connection = new SqlConnection(ClassSettingsData.ConnectionString);\n");
            script.Append("        SqlCommand command = new SqlCommand(query, connection);\n");
            script.Append("        try\n");
            script.Append("        {\n");
            script.Append("            connection.Open();\n");
            script.Append("            rowsAffected = command.ExecuteNonQuery();\n");
            script.Append("        }\n");
            script.Append("        catch {}\n");
            script.Append("        finally { connection.Close(); }\n");
            script.Append("        return ( rowsAffected > 0 );\n    }\n");
            return script.ToString();
        }

        private static string DeleteByID(DataTable dt)
        {
            StringBuilder script = new StringBuilder();
            DataRow firstDR = dt.Rows[0];
            script.Append($"\n    public static bool Delete{dt.TableName}ByID (int {firstDR["Column Name"]}");
            script.Append(")\n    {\n");
            script.Append($"        string query = $\"EXEC SP_Delete{dt.TableName}ByID @{firstDR["Column Name"]} = {firstDR["Column Name"]}\";\n");
            script.Append("        int rowsAffected = 0;\n");
            script.Append("        SqlConnection connection = new SqlConnection(ClassSettingsData.ConnectionString);\n");
            script.Append("        SqlCommand command = new SqlCommand(query, connection);\n");
            script.Append("        try\n");
            script.Append("        {\n");
            script.Append("            connection.Open();\n");
            script.Append("            rowsAffected = command.ExecuteNonQuery();\n");
            script.Append("        }\n");
            script.Append("        catch {}\n");
            script.Append("        finally { connection.Close(); }\n");
            script.Append("        return ( rowsAffected > 0 );\n    }\n");
            return script.ToString();
        }
    }
}