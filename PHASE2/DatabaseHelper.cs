using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHASE2
{
    internal class DatabaseHelper
    {
        private static string connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|" +
            "\\BookStore.mdf;Integrated Security=True;Connect Timeout=30";

        //for insert, update, and delete
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //to pull data from dtbs
        public static DataTable ExecuteQuery(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                return dt;
            }
        }

        //returns single value
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        //returns DataTable
        public static DataTable ExecuteReader(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        //helper method for making compiler not angry about using ?? to compare values
        public static object DbValue(object value)
        {
            return value ?? DBNull.Value;
        }

        //just avoids putting sql code into cs files, calls existing query method vicariously
        public static void LoadPublishers(ComboBox cbo)
        {
            cbo.DataSource = ExecuteQuery("SELECT pub_id, pub_name FROM publishers ORDER BY pub_id");
            cbo.DisplayMember = "pub_name";
            cbo.ValueMember = "pub_id";
        }


    }
}
