using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Model;
using Common;

namespace BookDAL
{
    public class CategoryDAL
    {
        public List<Categories> CateList()
        {
            List<Categories> list = new List<Categories>();
            string sql = "select * from Categories";
            DataSet ds = DBHelper.GetDataSet(sql, null);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Categories cate = new Categories();
                cate.ID =Convert.ToInt32( item["id"].ToString());
                cate.Name = item["name"].ToString();
                list.Add(cate);
            }

            return list;
        }
    }
}
