using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHASE2
{
    internal class Employee
    {
        public string EmpId { get; set; }       
        public string FName { get; set; }       
        public string? MInit { get; set; }     
        public string LName { get; set; }      
        public short? JobId { get; set; }      
        public byte? JobLvl { get; set; }       
        public string? PubId { get; set; }      
        public DateTime? HireDate { get; set; } 

        

        public void Save()
        {
            string sql = @"INSERT INTO employee 
                           (emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date)
                           VALUES (@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_date)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@emp_id", EmpId),
                new SqlParameter("@fname", FName),
                new SqlParameter("@minit", DatabaseHelper.DbValue(MInit)),
                new SqlParameter("@lname", LName),
                new SqlParameter("@job_id", DatabaseHelper.DbValue(JobId)),
                new SqlParameter("@job_lvl", DatabaseHelper.DbValue(JobLvl)),
                new SqlParameter("@pub_id", DatabaseHelper.DbValue(PubId)),
                new SqlParameter("@hire_date", DatabaseHelper.DbValue(HireDate))
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
