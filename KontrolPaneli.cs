using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class KontrolPaneli
    {
        // Methodlar
        public KontrolPaneli(int genislik, int yukseklik)
        {
            this.cizimAlani.BoyutAta(genislik, yukseklik);
            this.cizimAlani.RenkAta(ConsoleColor.Cyan);
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public void Ciz()
        {
            this.cizimAlani.Ciz();
            this.MenuCiz();
        }//kontrol panelini cizdiren method
        public void KonumAta(int x, int y)
        {
            this.cizimAlani.KonumAta(x, y);
            this.x = x;
            this.y = y;
        }
        public void MenuCiz()
        {
            Console.SetCursorPosition(this.x + 7, this.y + 1);
            Console.WriteLine("KONTROL PANELI");
            Console.SetCursorPosition(this.x + 7, this.y + 3);
            Console.WriteLine("Şekil Ekle   ( E )");
            Console.SetCursorPosition(this.x + 7, this.y + 5);
            Console.WriteLine("SOLA OTELE   ( A )");
            Console.SetCursorPosition(this.x + 7, this.y + 7);
            Console.WriteLine("SAGA OTELE   ( D )");
            Console.SetCursorPosition(this.x + 7, this.y + 9);
            Console.WriteLine("YUKARI OTELE ( W )");
            Console.SetCursorPosition(this.x + 7, this.y + 11);
            Console.WriteLine("AŞAĞI OTELE  ( S )");
        }//menu cizdiren fonksiyon

        // Alanlar
        private Dortgen cizimAlani = new Dortgen();
        private int genislik;
        private int x;
        private int y;
        private int yukseklik;
    }
}
