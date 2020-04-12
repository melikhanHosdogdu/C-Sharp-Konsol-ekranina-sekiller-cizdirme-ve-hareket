//author Melikhan Hoşdoğdu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Program
    {
        static void Main(string[] args)
        {
            int console_gen = Console.WindowWidth;//pencere genisligi ogreniliyor

            int console_yuk = Console.WindowHeight;//pencere yuksekligi ogreniliyor

            SahnePaneli sahne_paneli = new SahnePaneli(console_gen * 2 / 3, console_yuk - 1);//sahne boyutları atanıyor

            KontrolPaneli kontrol_paneli = new KontrolPaneli(console_gen / 3, console_yuk / 2 - 1);//kontrol paneli boyutları atanıyor

            BilgiPaneli bilgi_paneli = new BilgiPaneli(console_gen / 3, console_yuk / 2 - 1);//bilgi paneli boyutları atanıyor

       //     Dortgen dortgen = new Dortgen(20, 20);       //sınırlar belirleniyor      

            sahne_paneli.KonumAta(0, 0);//konum atanıyor

            kontrol_paneli.KonumAta(console_gen * 2 / 3, 0);//konum atanıyor

            bilgi_paneli.KonumAta(console_gen * 2 / 3, console_yuk / 2);//konum atanıyor

            Dortgen yeniSekil = null;

            while (true)//dongoye giriliyor
            {
                Console.Clear();

                sahne_paneli.Ciz();//ilk cizimler yapılıyor

                kontrol_paneli.Ciz();//ilk cizimler yapılıyor

                bilgi_paneli.Ciz();//ilk cizimler yapılıyor

                ConsoleKeyInfo info = Console.ReadKey(); //kullanıcını girecegi harf degiskeni tanımlanıyor

                if (info.Key == ConsoleKey.E)//karar yapıları devreye giriyor
                {
                    yeniSekil = new Dortgen(20, 20);

                    sahne_paneli.AktifSekilAta(yeniSekil);

                    bilgi_paneli.SekilAta(yeniSekil);

                    yeniSekil.Ciz();
                }
                if (yeniSekil != null)

                {
                    if (info.Key == ConsoleKey.A)
                    {
                        sahne_paneli.SekilSolaOtele();
                    }
                    if (info.Key == ConsoleKey.D)
                    {
                        sahne_paneli.SekilSagaOtele();
                    }
                    if (info.Key == ConsoleKey.W)
                    {
                        sahne_paneli.SekilYukariOtele();
                    }
                    if (info.Key == ConsoleKey.S)
                    {
                        sahne_paneli.SekilAsagiOtele();
                    }
                }
            }
        }
    }
}
