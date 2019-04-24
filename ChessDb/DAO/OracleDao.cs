using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDb.DAO
{
    public class OracleDao
    {
        private string oradb;// = "Data Source=ORCL;User Id=hr;Password=hr;";

        private OracleConnection conn;// C#

        public OracleDao()
        {
            oradb = "Data Source=ORCL;User Id=hr;Password=hr;";
            conn = new OracleConnection(oradb); // C#
        }

        public void openConnetion() {
            conn.Open();
        }

        public void closeConnetion()
        {
            conn.Dispose();
        }

        public OracleDataReader executePr(string sentece)
        {

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = sentece;//"select department_name from departments where department_id = 10"; 
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            return dr;
        }    
    }
}
