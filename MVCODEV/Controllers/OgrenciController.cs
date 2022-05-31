using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCODEV.Models;

namespace MVCODEV.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
     
        }
        public IActionResult OgrenciEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OgrenciEkle(FormCollection form)
        {
            OgrenciContext db = new OgrenciContext();
            var model = new Ogrenci();
            model.Ad = form["Username"].ToString();
            model.Soyad = form["UserSurName"].ToString();
            db.Ogrenciler.Add(model);
            db.SaveChanges();

            return View();
        }
    }
}
