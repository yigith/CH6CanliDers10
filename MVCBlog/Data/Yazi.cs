namespace MVCBlog.Data
{
    public class Yazi
    {
        public int Id { get; set; }

        public int KategoriId { get; set; }

        public string Baslik { get; set; } = "";

        // HTML içerir
        public string Icerik { get; set; } = "";

        public string? Resim { get; set; }

        public DateTime OlusturulmaZamani { get; set; } = DateTime.Now;

        public bool YayinlandiMi { get; set; }
    }
}
