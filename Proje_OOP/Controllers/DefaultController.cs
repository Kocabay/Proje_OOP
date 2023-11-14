using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba proje cok iyi duruyor";
            ViewBag.m3 = "selamlar";

        }


        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }




        int Cevre()
        {
            int kısa = 10;
            int uzun = 20;
            int sonuc = 2 * (kısa + uzun);
            return sonuc;
        }

        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;

        }



        string cumle()
        {
            string c = "Küçük Hanımlar Küçük Beyler sizler hepiniz geleceğin birer gülüsünüz.";
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }


        public IActionResult Urunler()
        {
            Kullanıcı("Omer1");
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            mesajlar();
            ViewBag.faktor = Faktoriyel(6);
            return View();

        }
        void Kullanıcı(string kullanıcıadı)
        {
            ViewBag.v = kullanıcıadı;
        }
        public IActionResult Musteriler()
        {
            Kullanıcı("Omer2424");
            ViewBag.d = cumle();
            return View();
        }

        int Faktoriyel(int p)
        {
            int f = 1;
            for (int i = 1; i <= p; i++)
            {
                f = f * i;
            }
            return f;
        }


        public IActionResult Index()

        {
            ViewBag.tp = Topla(20, 35);
            Kullanıcı("Omer0001");
            MesajListesi("parametre");
            mesajlar();
            return View();
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
 
            sehirler.Ad = "Sakarya";
            sehirler.Id = 1;
            sehirler.Nufus = 10000000;
            sehirler.Ulke = "Turkey";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Sarı";


            ViewBag.v3 = sehirler.Ad;
            ViewBag.v1 = sehirler.Id;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;


            sehirler.Id = 2;
            sehirler.Ad = "Üsküp";
            sehirler.Nufus = 40000000;
            sehirler.Ulke = "ABD";
            sehirler.Renk1 = "Mavi";
            sehirler.Renk2 = "Kırmızı";

            ViewBag.z1 = sehirler.Id;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            return View();
        }

    }
}
