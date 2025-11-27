using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PHASE2
{
    internal class Author
    {
        public string AuthorId { get; set; }          
        public string LastName { get; set; }          
        public string FirstName { get; set; }         
        public string Phone { get; set; }             
        public string? Address { get; set; }          
        public string? City { get; set; }             
        public string? State { get; set; }            
        public string? Zip { get; set; }              
        public bool Contract { get; set; }

        public void Save()
        {
            string sql = @"INSERT INTO authors 
                (au_id, au_lname, au_fname, phone, address, city, state, zip, contract)
                VALUES (@id, @lname, @fname, @phone, @address, @city, @state, @zip, @contract)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@id", AuthorId),
                new SqlParameter("@lname", LastName),
                new SqlParameter("@fname", FirstName),
                new SqlParameter("@phone", Phone ?? "UNKNOWN"),
                new SqlParameter("@address", DatabaseHelper.DbValue(Address)),
                new SqlParameter("@city", DatabaseHelper.DbValue(City)),
                new SqlParameter("@state", DatabaseHelper.DbValue(State)),
                new SqlParameter("@zip", DatabaseHelper.DbValue(Zip)),
                new SqlParameter("@contract", Contract)
            );
        }
    }
}
