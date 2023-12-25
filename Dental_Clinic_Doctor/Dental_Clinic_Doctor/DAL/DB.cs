using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Clinic_Doctor.DAL
{
    class DB
    {

        static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dental_Clinic.mdf;Integrated Security=True;Connect Timeout=30");
        static SqlCommand cmd;

        private static void openconn()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private static void closeconn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        protected static DataTable EXUTETABLE(string quary, CommandType type, params SqlParameter[] param)
        {
            conn.Open();
            cmd = new SqlCommand(quary, conn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(param);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            conn.Close();
            return dt;
        }

        protected static void EXUTENONEQUARY(string quary, CommandType type, params SqlParameter[] param)
        {
            conn.Open();
            cmd = new SqlCommand(quary, conn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(param);


            cmd.ExecuteNonQuery();

            conn.Close();

        }

        protected static SqlParameter createparm(string name, SqlDbType type, object value)
        {
            SqlParameter parme = new SqlParameter();
            parme.ParameterName = name;
            parme.SqlDbType = type;
            parme.Value = value;

            return parme;
        }


    }
}
