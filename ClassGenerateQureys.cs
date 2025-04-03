using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator
{
    public static class ClassGenerateQureys
    {
        public static string CreateNewDataBase(string DataBaseName)
        {
            return "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = " + "'" + DataBaseName + "')\n    BEGIN\n        CREATE DATABASE" + DataBaseName + ";\n    END\n USE " + DataBaseName + ";\n\nGO\n\n";      
        }

        public static string UseExistDataBase(string DataBaseName)
        {
            return "USE " + DataBaseName + ";\n\nGO\n\n";
        }

        public static string TableQurey(DataTable dt)
        {
            string qurey = "";
            qurey += $"CREATE TABLE {dt.TableName} (\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                qurey += $"    {dr["Column Name"]} {dr["Data Type"].ToString().ToUpper()} ";
                if (bool.Parse(dr["Allow Nulls"].ToString()))
                {
                    if (dt.Rows.Count == i + 1)
                        qurey += "NOT NULL\n";
                    else
                        qurey += "NOT NULL,\n";
                }
                else
                {
                    if (dt.Rows.Count == i + 1)
                        qurey += "NULL\n";
                    else
                        qurey += "NULL,\n";
                }
            }
            qurey += ");\n\n";
            return qurey;
        }

        public static string StoredProceduresQurey(DataTable dt)
        {
            return AddNewStoredProceduresQurey(dt) +
                UpdateStoredProceduresQurey(dt) +
                DeleteByIDStoredProceduresQurey(dt) +
                GetAllStoredProceduresQurey(dt) +
                GetByIDStoredProceduresQurey(dt);
        }

        private static string AddNewStoredProceduresQurey(DataTable dt)
        {
            string qurey = $"\n\nGO\n\n-- Add New {dt.TableName} Stored Procedures Qurey\n";
            qurey += $"CREATE PROCEDURE SP_AddNew{dt.TableName}\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    qurey += $"    @{dr["Column Name"]} {dr["Data Type"].ToString().ToUpper()}\n";
                else
                    qurey += $"    @{dr["Column Name"]} {dr["Data Type"].ToString().ToUpper()},\n";
            }
            qurey += $"AS\nBEGIN\n    INSERT INTO {dt.TableName} (";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    qurey += $"{dr["Column Name"]}";
                else
                    qurey += $"{dr["Column Name"]}, ";
            }
            qurey += ")\n    VALUES (";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    qurey += $"@{dr["Column Name"]}";
                else
                    qurey += $"@{dr["Column Name"]}, ";
            }
            DataRow firstDR = dt.Rows[0];
            qurey += $");\nSET @{firstDR["Column Name"]} = SCOPE_IDENTITY();\nEND";
            return qurey;
        }

        private static string UpdateStoredProceduresQurey(DataTable dt)
        {
            string qurey = $"\n\nGO\n\n-- Update {dt.TableName} By ID Stored Procedures Qurey\n";
            qurey += $"CREATE PROCEDURE SP_Update{dt.TableName}\n";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    qurey += $"    @{dr["Column Name"]} {dr["Data Type"].ToString().ToUpper()}\n";
                else
                    qurey += $"    @{dr["Column Name"]} {dr["Data Type"].ToString().ToUpper()},\n";
            }
            qurey += $"AS\nBEGIN\n    UPDATE {dt.TableName}\n    SET ";
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dt.Rows.Count == i + 1)
                    qurey += $"{dr["Column Name"]} = @{dr["Column Name"]}";
                else
                    qurey += $"{dr["Column Name"]} = @{dr["Column Name"]}, ";
            }
            DataRow firstDR = dt.Rows[0];
            qurey += $"\n    WHERE {firstDR["Column Name"]} = @{firstDR["Column Name"]}\nEND";
            return qurey;
        }

        private static string GetAllStoredProceduresQurey(DataTable dt)
        {
            return $"\n\nGO\n\n-- Get All {dt.TableName} Stored Procedures Qurey\n\nCREATE PROCEDURE SP_GetAll{dt.TableName}\nAS\nBEGIN\n    SELECT * FROM {dt.TableName}\nEND";
        }

        private static string GetByIDStoredProceduresQurey(DataTable dt)
        {
            return $"\n\nGO\n\n-- Get {dt.TableName} By ID Stored Procedures Qurey\n\nCREATE PROCEDURE SP_Get{dt.TableName}ByID\n    @{dt.Rows[0]["Column Name"]} {dt.Rows[0]["Data Type"]}\nAS\nBEGIN\n    SELECT * FROM {dt.TableName} WHERE {dt.Rows[0]["Column Name"]} = @{dt.Rows[0]["Column Name"]}\nEND";
        }

        private static string DeleteByIDStoredProceduresQurey(DataTable dt)
        {
            return $"\n\nGO\n\n-- Delete {dt.TableName} By ID Stored Procedures Qurey\n\nCREATE PROCEDURE SP_Delete{dt.TableName}ByID\n    @{dt.Rows[0]["Column Name"]} {dt.Rows[0]["Data Type"]}\nAS\nBEGIN\n    DELETE FROM {dt.TableName} WHERE {dt.Rows[0]["Column Name"]} = @{dt.Rows[0]["Column Name"]}\nEND";
        }
    }
}
