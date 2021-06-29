using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCBooksApp.Models;

namespace MVCBooksApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        public ActionResult Books()
        {
            MVCBooksApp.Models.Book bookList = new Book();
            return View();            
        }

        public ActionResult GetBooks()
        {
            MVCBooksApp.Models.Book bookList = new Book();
            var booklist = bookList.getBooksList();
            return Json(new { data = booklist }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MVCBooksApp.Models.Book bookList = new Book();
            var booklist = bookList.getBooksList().Find(i=>i.BookId==id);
            if (booklist == null)
            {
                return HttpNotFound();
            }
            return View(booklist);
        }
    }
}