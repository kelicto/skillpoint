using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using KeLi.SkillPoint.App.Properties;

namespace KeLi.SkillPoint.App.Thinking
{
    public class DataTableLoading : IResult
    {
        public void ShowResult()
        {
            if (LoadDataTable())
            {
                Console.WriteLine("Load Success!");
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine(Resources.PuFormula1);
                Console.WriteLine();
            }
        }

        private static bool LoadDataTable()
        {
            var connSql = ConfigurationManager.ConnectionStrings[Resources.ConnStrKeyName].ToString();

            using (var conn = new SqlConnection(connSql))
            {
                conn.Open();

                using (var cmd = new SqlCommand(Resources.QueryStudentSql, conn))
                {
                    var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    var table = new DataTable(Resources.StudentInfo);

                    table.Load(reader);

                    return table.Rows.Count > 0;
                }
            }
        }
    }
}