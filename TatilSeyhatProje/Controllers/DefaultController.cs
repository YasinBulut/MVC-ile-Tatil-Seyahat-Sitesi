using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyhatProje.Models.Sınıflar;

namespace TatilSeyhatProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();  
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        public ActionResult Hakkımda()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var değerler = c.Blogs.OrderBy(x => x.ID).Take(2).ToList();
            return PartialView(değerler);
        }
        public PartialViewResult Partial2()
        {
            var değerler = c.Blogs.OrderByDescending(x => x.ID).Take(1).ToList();
            return PartialView(değerler);
        }
        public PartialViewResult Partial3()
        {
            var değerler = c.Blogs.Take(10).ToList();
            return PartialView(değerler);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}