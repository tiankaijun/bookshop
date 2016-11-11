using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookDAL;
using Model;
namespace BookBLL
{
    public class CategoryBLL
    {
        CategoryDAL cd = new CategoryDAL();
        public List<Categories> CateList()
        {
            return cd.CateList();
        }
    }
}
