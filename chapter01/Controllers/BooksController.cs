using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookBLL;
using Model;

namespace chapter01.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        public ActionResult Index()
        {
            return View();
        }

        BookBLL.BookBLL bb = new BookBLL.BookBLL();


        public ActionResult BookList(string oName = "clicks", int id = 0)
        {
            List<Books> listBook = null;
           
                listBook = bb.GetBooksList(oName,id);
            return View(listBook);//强类型视图传参
        }
       
        public ActionResult BookDetail(int? id)
        {
            int i = id ?? 0;
         Books book=   bb.GetBookById(i);
         ViewData["book"] = book;
            return View();
        }


    }
}
