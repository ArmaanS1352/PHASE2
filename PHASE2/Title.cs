using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHASE2
{
    internal class Title
    {
        public string TitleId { get; set; }
        public string TitleName { get; set; }
        public string Type { get; set; }          
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime? PubDate { get; set; }
        public string PublisherId { get; set; }



        public void save()
        {
            string sql = @"INSERT INTO titles 
                           (title_id, title, type, price, advance, royalty, ytd_sales, notes, pubdate, pub_id)
                           VALUES (@id, @title, @type, @price, @advance, @royalty, @ytdsales, @notes, @pubdate, @pubid)";

            DatabaseHelper.ExecuteNonQuery(sql,
                new SqlParameter("@id", TitleId),
                new SqlParameter("@title", TitleName),
                new SqlParameter("@type", DatabaseHelper.DbValue(Type)),
                new SqlParameter("@pubid", DatabaseHelper.DbValue(PublisherId)),
                new SqlParameter("@price", DatabaseHelper.DbValue(Price)),
                new SqlParameter("@advance", DatabaseHelper.DbValue(Advance)),
                new SqlParameter("@royalty", DatabaseHelper.DbValue(Royalty)),
                new SqlParameter("@ytdsales", DatabaseHelper.DbValue(YtdSales)),
                new SqlParameter("@notes", DatabaseHelper.DbValue(Notes)),
                new SqlParameter("@pubdate", DatabaseHelper.DbValue(PubDate))
            );
        }
    }
}
