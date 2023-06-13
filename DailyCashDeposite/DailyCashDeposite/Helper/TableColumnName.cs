using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyCashDeposite.Helper
{
    public static class CompanySettingColumn
    {
        public static readonly string CompanyNumber = "CompanyNumber";
        public static readonly string OffsetGlAccount = "OffsetGlAccount";
        public static readonly string ContactName = "ContactName";
        public static readonly string ContactEmail = "ContactEmail";
    }

    public static class DepositColumn
    {
        public static readonly string Journal = "Journal";
        public static readonly string Entry = "Entry";
        public static readonly string DepositDate = "DepositDate";
        public static readonly string PeriodPostingDate = "PeriodPostingDate";
        public static readonly string OffSetGLAccount = "OffSetGLAccount";
        public static readonly string Description = "Description";
        public static readonly string Debit = "Debit";
        public static readonly string Credit = "Credit";
        public static readonly string Bun = "Bun";
        public static readonly string TransactionTotal = "TransactionTotal";
        public static readonly string Status = "Status";
        public static readonly string StatusDescription = "StatusDescription";
        public static readonly string DateImported = "DateImported";
        public static readonly string TimeImported = "TimeImported";
        public static readonly string WindowsUser = "WindowsUser";

    }

    public static class ColumnNames
    {
        public static string GetAllColumnsTogether(Type type)
        {
            var columnNames = "";
            foreach (var property in type.GetFields())
            {
                columnNames += property.GetValue(property).ToString().ToUpper() + ",";
            }
            return columnNames.TrimEnd(',');
        }

        public static string GetMatchingColumnName(Type type,string givenColumnName)
        {
            var columnName = "";
            foreach (var property in type.GetFields())
            {
                var propValue = property.GetValue(property).ToString().ToUpper();
                givenColumnName = givenColumnName.Split(' ')[0].ToUpper();
                if (propValue.Contains(givenColumnName))
                {
                    columnName= propValue;
                    break;
                }
            }
            return columnName;
        }
    }
}
