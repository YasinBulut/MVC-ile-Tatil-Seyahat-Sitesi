using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyhatProje.Models.Sınıflar;

namespace TatilSeyhatProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.Blogs.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir",bl);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorum = c.Yorums.ToList();
            return View(yorum);
        }
        public ActionResult YorumSil(int id)
        {
            var y = c.Yorums.Find(id);
            c.Yorums.Remove(y);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yrm = c.Yorums.Find(id);
            return View("YorumGetir",yrm);
        }
        public ActionResult YorumGuncelle(Yorum y)
        {
            var yrm = c.Yorums.Find(y.ID);
            yrm.KullaniciAd = y.KullaniciAd;
            yrm.Mail = y.Mail;
            yrm.Yorumlar = y.Yorumlar;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}