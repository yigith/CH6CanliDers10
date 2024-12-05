using MVCBlog.Data;

namespace MVCBlog.Models
{
    public class AnasayfaViewModel
    {
        public List<Kategori> Kategoriler { get; set; } = new();

        public List<Yazi> Yazilar { get; set; } = new();

        public Kategori? SeciliKategori { get; set; }
    }
}
