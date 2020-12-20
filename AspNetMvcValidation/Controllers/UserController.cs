using AspNetMvcValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvcValidation.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUser(User model)
        {
            if (ModelState.IsValid)
            {
                //Eğer alanlara girilen değerler validated(doğrulanmış) ise bu koşula girer.
            }

            return View();
        }
    }
}