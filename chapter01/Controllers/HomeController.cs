using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookBLL;
using Model;

namespace chapter01.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        UserBLL ub = new UserBLL();

       
        public ActionResult Login()
        {
            return View();
        }
       
        /// <summary>
        /// 参数映射
        /// </summary>
        /// <param name="username">映射前台表单的name</param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string username,string password )
        {
            //string id = Request.Form["username"].ToString();
            //string pwd = Request.Form["password"].ToString();
            Users u = ub.GetLoginInfo(username, password);
            Session["user"] = u;

            return View("Index");
        }

        public ActionResult Exit()
        {
            Session["user"] =null;
            return View("Index");
        }

    }
}
