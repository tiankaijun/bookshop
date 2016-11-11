using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookBLL;
using Model;

namespace chapter01.Controllers
{
    public class CateController : Controller
    {

        CategoryBLL cb = new CategoryBLL();
        //
        // GET: /Cate/

        public ActionResult Index()
        {
            List<Categories> list = cb.CateList();
            return View(list);
        }

       

        


    }
}
