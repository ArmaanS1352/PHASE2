using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHASE2
{
    internal class Publisher
    {
        public string PublisherId { get; set; }        
        public string? PublisherName { get; set; }     
        public string? City { get; set; }              
        public string? State { get; set; }             
        public string? Country { get; set; }

        public void Save()
        {
            string sql = @"INSERT INTO publishers 
                (pub_id, pub_name, city, state, country)
                VALUES (@id, @name, @city, @state, @country)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@id", PublisherId),
                new SqlParameter("@name", DatabaseHelper.DbValue(PublisherName)),
                new SqlParameter("@city", DatabaseHelper.DbValue(City)),
                new SqlParameter("@state", DatabaseHelper.DbValue(State)),
                new SqlParameter("@country", DatabaseHelper.DbValue(Country ?? "USA"))
            );
        }
    }
}
