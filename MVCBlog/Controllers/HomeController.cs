using Microsoft.AspNetCore.Mvc;
using MVCBlog.Data;
using MVCBlog.Models;
using System.Diagnostics;

namespace MVCBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? kid)
        {
            Kategori? kategori = null;
            List<Yazi> yazilar = Veri.Yazilar();

            if (kid != null)
            {
                kategori = Veri.Kategoriler().FirstOrDefault(k => k.Id == kid);

                if (kategori == null)
                    return NotFound();

                yazilar = yazilar.Where(y => y.KategoriId == kid).ToList();
            }

            var vm = new AnasayfaViewModel()
            {
                Kategoriler = Veri.Kategoriler().OrderBy(k => k.Ad).ToList(),
                Yazilar = yazilar.OrderByDescending(y => y.OlusturulmaZamani).ToList(),
                SeciliKategori = kategori
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
