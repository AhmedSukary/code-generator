using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Generator
{
    public static class ClassGlobal
    {
        public static string GetTypeOf(string dataType)
        {
            switch (dataType)
            {
                case "char(10)":
                    dataType = "string";
                    break;
                case "bit":
                    dataType = "bool";
                    break;
                case "date":
                    dataType = "DateTime";
                    break;
                case "datetime":
                    dataType = "DateTime";
                    break;
                case "datetime2(7)":
                    dataType = "DateTime";
                    break;
                case "float":
                    dataType = "float";
                    break;
                case "int":
                    dataType = "int";
                    break;
                case "money":
                    dataType = "float";
                    break;
                case "nchar(10)":
                    dataType = "string";
                    break;
                case "nvarchar(50)":
                    dataType = "string";
                    break;
                case "nvarchar(MAX)":
                    dataType = "string";
                    break;
                case "smallint":
                    dataType = "short";
                    break;
                case "varchar(50)":
                    dataType = "string";
                    break;
                case "varchar(100)":
                    dataType = "string";
                    break;
                case "varchar(200)":
                    dataType = "string";
                    break;
                case "varchar(MAX)":
                    dataType = "string";
                    break;
            }
            return dataType;
        }
        public static string GetInitializeValue(string dataType)
        {
            switch (dataType)
            {
                case "char(10)":
                    dataType = "\"\"";
                    break;
                case "bit":
                    dataType = "bool";
                    break;
                case "date":
                    dataType = "DateTime.Now";
                    break;
                case "datetime":
                    dataType = "DateTime.Now";
                    break;
                case "datetime2(7)":
                    dataType = "DateTime.Now";
                    break;
                case "float":
                    dataType = "0";
                    break;
                case "int":
                    dataType = "0";
                    break;
                case "money":
                    dataType = "0";
                    break;
                case "nchar(10)":
                    dataType = "\"\"";
                    break;
                case "nvarchar(50)":
                    dataType = "\"\"";
                    break;
                case "nvarchar(MAX)":
                    dataType = "\"\"";
                    break;
                case "smallint":
                    dataType = "0";
                    break;
                case "varchar(50)":
                    dataType = "\"\"";
                    break;
                case "varchar(100)":
                    dataType = "\"\"";
                    break;
                case "varchar(200)":
                    dataType = "\"\"";
                    break;
                case "varchar(MAX)":
                    dataType = "\"\"";
                    break;
            }
            return dataType;
        }
    }
}
