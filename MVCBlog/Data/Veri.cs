namespace MVCBlog.Data
{
    public static class Veri
    {
        public static List<Kategori> Kategoriler()
        {
            return new List<Kategori>
            {
                new Kategori { Id = 1, Ad = "Teknoloji" },
                new Kategori { Id = 2, Ad = "Doğa ve Manzara" },
                new Kategori { Id = 3, Ad = "Seyahat" },
                new Kategori { Id = 4, Ad = "Tarih" }
            };
        }

        public static List<Yazi> Yazilar()
        {
            return new List<Yazi>
            {
                // Teknoloji Kategorisi
                new Yazi
                {
                    Id = 1,
                    KategoriId = 1,
                    Baslik = "Verimli Çalışma Alanları: Teknoloji ve Konfor",
                    Icerik = "<p>Modern çalışma alanları, teknoloji ve konforu birleştirerek verimliliği artırmaya yardımcı olur. Laptopunuzun başında rahat bir ortam yaratmak, işlerinizin hızını ve kalitesini artırabilir.</p>",
                    Resim = "01.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 2,
                    KategoriId = 1,
                    Baslik = "Kahve Molasında Teknolojiyle Daha Fazla Zaman Geçirin",
                    Icerik = "<p>Hızla gelişen teknoloji, her geçen gün yaşamımızı daha da kolaylaştırıyor. Özellikle kahve molalarında bile işleri hızlandıran cihazlar sayesinde zamanımızı verimli kullanabiliyoruz.</p>",
                    Resim = "02.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 3,
                    KategoriId = 1,
                    Baslik = "Minimalizm ve Teknoloji: Temiz Bir Çalışma Alanı",
                    Icerik = "<p>Minimalist bir çalışma alanı, yalnızca en gerekli olan cihaz ve araçlarla işlerinizi yapmanıza olanak tanır. Teknolojik aletlerinizi doğru kullanarak huzurlu bir ortam yaratabilirsiniz.</p>",
                    Resim = "03.jpg",
                    YayinlandiMi = true
                },

                // Doğa ve Manzara Kategorisi
                new Yazi
                {
                    Id = 4,
                    KategoriId = 2,
                    Baslik = "Savaşın İzi: Eskimiş Bir At Arabası",
                    Icerik = "<p>Geçmişin izlerini taşıyan eski bir at arabası, yıllar önceki zorlukları ve geçirdiği evrimleri simgeliyor. Doğanın daima değişen yüzüyle birleşen insan emeği, tarihin derinliklerine dokunuyor.</p>",
                    Resim = "04.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 5,
                    KategoriId = 2,
                    Baslik = "İneklerin Sesi: Doğada Hayat",
                    Icerik = "<p>Doğada kaybolmuş bir kırmızı inek, doğanın doğal sakinlerinden birine dönüşmüş. Bu sessiz ama güçlü varlıklar, çevreyi ve ekosistemi koruyan önemli unsurlardır.</p>",
                    Resim = "05.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 6,
                    KategoriId = 2,
                    Baslik = "Doğanın Harika Düzeni",
                    Icerik = "<p>Doğa, her zaman kendi sistemine göre çalışır. Bu harika düzeni görmek, hayata olan bakış açınızı değiştirebilir ve doğayı daha yakından anlamanızı sağlayabilir.</p>",
                    Resim = "06.jpg",
                    YayinlandiMi = true
                },

                // Seyahat Kategorisi
                new Yazi
                {
                    Id = 7,
                    KategoriId = 3,
                    Baslik = "Amazon'da Hayatta Kalmak: Survivor Deneyimi",
                    Icerik = "<p>Amazon'un derinliklerinde hayatta kalmak, insanın doğayla ne kadar iç içe olduğunu gösteriyor. Bu eşsiz doğada, survival bir macera yaşamak her zaman unutulmaz olur.</p>",
                    Resim = "07.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 8,
                    KategoriId = 3,
                    Baslik = "Sütlaç ve Seyahatin Lezzeti",
                    Icerik = "<p>Seyahat ederken, farklı kültürlerin yemekleriyle tanışmak her zaman keyiflidir. Özellikle farklı ülkelerdeki sütlaç tatları, her zaman şaşırtıcı ve unutulmaz bir deneyim sunar.</p>",
                    Resim = "08.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 9,
                    KategoriId = 3,
                    Baslik = "Zamanın Tanığı: Klasik Otomobiller",
                    Icerik = "<p>Bir otomobil, sadece bir ulaşım aracı değil, zamanın tanığıdır. Klasik otomobiller, geçmişin estetiğiyle modern dünyaya bir köprü kurar ve seyahati bir sanat haline getirir.</p>",
                    Resim = "09.jpg",
                    YayinlandiMi = true
                },

                // Tarih Kategorisi
                new Yazi
                {
                    Id = 10,
                    KategoriId = 4,
                    Baslik = "Gün Batımında Balıkçılar ve Tarih",
                    Icerik = "<p>Bir balıkçı barınağında gün batımını izlerken, denizle insanın ilişkisinin ne kadar derin olduğunu fark edersiniz. Bu barınaklar, tarih boyunca insan yaşamının merkezlerinden biri olmuştur.</p>",
                    Resim = "10.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 11,
                    KategoriId = 4,
                    Baslik = "Deniz, Dağlar ve Falezler: Bir Doğa Mirası",
                    Icerik = "<p>Deniz ve dağlar arasındaki bu görsel şölen, tarihin derinliklerine inmenin bir yoludur. Falezler, binlerce yıl önce şekillenmiş, insanlık tarihinin bir parçasıdır.</p>",
                    Resim = "11.jpg",
                    YayinlandiMi = true
                },
                new Yazi
                {
                    Id = 12,
                    KategoriId = 4,
                    Baslik = "Eski Binaların Kapıları: Tarihin Gizemi",
                    Icerik = "<p>Bir kapı, sadece bir geçiş yolu değil, aynı zamanda tarih boyunca yaşanmış bir öykünün başlangıcı olabilir. Eski binaların kapıları, geçmişin derinliklerine açılan kapılardır.</p>",
                    Resim = "12.jpg",
                    YayinlandiMi = true
                }
            };
        }
    }

}
