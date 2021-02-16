using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyhatProje.Models.Sınıflar
{
    public class Yorum
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAd { get; set; }
        public string Mail { get; set; }
        public string Yorumlar { get; set; }
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }
}