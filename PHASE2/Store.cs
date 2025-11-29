using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHASE2
{
    internal class Store
    {
        public string StorId { get; set; }        
        public string? StorName { get; set; }     
        public string? StorAddress { get; set; }  
        public string? City { get; set; }         
        public string? State { get; set; }        
        public string? Zip { get; set; }




        public void Save()
        {
            string sql = @"INSERT INTO stores (stor_id, stor_name, stor_address, city, state, zip)
                           VALUES (@id, @name, @address, @city, @state, @zip)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@id", StorId),
                new SqlParameter("@name", DatabaseHelper.DbValue(StorName)),
                new SqlParameter("@address", DatabaseHelper.DbValue(StorAddress)),
                new SqlParameter("@city", DatabaseHelper.DbValue(City)),
                new SqlParameter("@state", DatabaseHelper.DbValue(State)),
                new SqlParameter("@zip", DatabaseHelper.DbValue(Zip))
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
