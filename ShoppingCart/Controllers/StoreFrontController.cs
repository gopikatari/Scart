using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingCartApp.DAL;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.Controllers
{
    public class StoreFrontController : Controller
    {

        private readonly MvcAffableBeanContext db = new MvcAffableBeanContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}