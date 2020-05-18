using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManagerClone.Controllers
{
    public class ExpenseMgrCloneController : Controller
    {
        // GET: ExpenseMgrClone
        public ActionResult Index()
        {
            return View();
        }
    }
}