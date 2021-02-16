using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyhatProje.Models.Sınıflar;

namespace TatilSeyhatProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogYorum by = new BlogYorum();
        Context c = new Context();  
        public ActionResult Index()
        {
            // var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(by);
        }   
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorums.Where(x => x.BlogID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum y)
        {
            c.Yorums.Add(y);
            c.SaveChanges();
            return PartialView();
        }

    }
}