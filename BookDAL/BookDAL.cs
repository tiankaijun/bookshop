using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Model;
using Common;

namespace BookDAL
{
    public class BookDAL
    {
        public List<Books> GetBooksList(string oName,int cid)
        {
            List<Books> listBook = new List<Books>();
            string sql = "select top(5) * from books where CategoryId=" + cid+" order by "+oName+" desc";
            DataSet ds = DBHelper.GetDataSet(sql, null);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Books b = new Books();
                b.ID = Convert.ToInt32(item["id"].ToString());
                b.Title = item["title"].ToString();
                b.Author = item["author"].ToString();
                b.UnitPrice = Convert.ToDouble(item["UnitPrice"]);
                b.TOC = item["TOC"].ToString();
                b.ISBN = item["ISBN"].ToString();
                b.ContentDescription = item["ContentDescription"].ToString();
                b.CategrayId = int.Parse(item["CategoryId"].ToString());
                b.PublisherId = int.Parse(item["publisherId"].ToString());
                b.Clicks = int.Parse(item["clicks"].ToString());
                b.PublishDate = DateTime.Parse(item["publishDate"].ToString());
                listBook.Add(b);
            }
            return listBook;
        }

        public DataSet GetBookDataSet()
        {
            string sql = "select id,Title,Author from Books";
            DataSet ds = DBHelper.GetDataSet(sql, null);
            return ds;
        }

        public Books GetBookById(int id)
        {
            Books b=null;
            string sql = "select  * from books where id="+id;

            SqlDataReader item = DBHelper.GetDataReader(sql, null);
            if (item.Read())
            {
                b = new Books();
                b.ID = Convert.ToInt32(item["id"].ToString());
                b.Title = item["title"].ToString();
                b.Author = item["author"].ToString();
                b.UnitPrice = Convert.ToDouble(item["UnitPrice"]);
                b.TOC = item["TOC"].ToString();
                b.ISBN = item["ISBN"].ToString();
                b.ContentDescription = item["ContentDescription"].ToString();
                b.CategrayId = int.Parse(item["CategoryId"].ToString());
                b.PublisherId = int.Parse(item["publisherId"].ToString());
                b.Clicks = int.Parse(item["clicks"].ToString());
                b.PublishDate = DateTime.Parse(item["publishDate"].ToString());
            }
                return b;
            
        }
    }
}
