using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using BookDAL;
using Model;

namespace BookBLL
{
    /// <summary>
    /// 书的逻辑层
    /// </summary>
    public class BookBLL
    {
        BookDAL.BookDAL bd = new BookDAL.BookDAL();
        public List<Books> GetBooksList(string oName,int cid)
        {
            return bd.GetBooksList(oName,cid);
        }

        public DataSet GetBookDataSet()
        {
            return bd.GetBookDataSet();
        }

        public Books GetBookById(int id)
        {
            return bd.GetBookById(id);
        }
    }
}
