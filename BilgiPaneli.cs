using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class BilgiPaneli
    {
        //metodlar
        public BilgiPaneli(int genislik, int yukseklik)
        {
            this.cizimAlani.BoyutAta(genislik, yukseklik);
            this.cizimAlani.RenkAta(ConsoleColor.Green);
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public void KonumAta(int x, int y)
        {
            this.cizimAlani.KonumAta(x, y);
            this.x = x;
            this.y = y;
        }
        public void Ciz()
        {
            this.cizimAlani.Ciz();
            if (this.aktifSekil != null)
            {
                this.BilgiCiz();
            }
        }
        public void BilgiCiz()
        {
            int bilgi_x = this.x + 6;
            int bilgi_y = this.y + 1;
            Console.SetCursorPosition(bilgi_x, bilgi_y);
            Console.WriteLine("X................:{0}", this.aktifSekil.X);
            Console.SetCursorPosition(bilgi_x, bilgi_y + 2);
            Console.WriteLine("Y................:{0}", this.aktifSekil.Y);
            Console.SetCursorPosition(bilgi_x, bilgi_y + 4);
            Console.WriteLine("Genislik.........:{0}", this.aktifSekil.Genislik);
            Console.SetCursorPosition(bilgi_x, bilgi_y + 6);
            Console.WriteLine("Yukseklik........:{0}", this.aktifSekil.Yukseklik);
            Console.SetCursorPosition(bilgi_x, bilgi_y + 8);
            Console.WriteLine("Yukseklik........:{0}", this.aktifSekil.Yukseklik);
            Console.SetCursorPosition(bilgi_x, bilgi_y + 8);
            Console.WriteLine("Renk.............:{0}", this.aktifSekil.Renk.ToString());
        }
        public void SekilAta(Dortgen sekil)
        {
            this.aktifSekil = sekil;
        }

        //alanlar
        private Dortgen aktifSekil;
        private Dortgen cizimAlani = new Dortgen();
        private int genislik;
        private int x;
        private int y;
        private int yukseklik;
    }
}
