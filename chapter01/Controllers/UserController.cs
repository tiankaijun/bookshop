using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Model;
using BookBLL;

namespace chapter01.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Regist()
        {
            return Content("<></>");
        }

        //单独写一个方法将生成的验证码存储到session

        [HttpPost]
        public ActionResult Regist(Users user)
        {
            if (ModelState.IsValid)
            {

            }
            else
            { 
               
            }

            return View();
        }

    }
}
