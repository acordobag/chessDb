using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDb.DAO
{
    class OracleDao
    {
        public static void executePr()
        {
            string oradb = "Data Source=ORCL;User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(oradb); // C#

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "select department_name from departments where department_id = 10"; cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            conn.Dispose();
        }    
    }
}
