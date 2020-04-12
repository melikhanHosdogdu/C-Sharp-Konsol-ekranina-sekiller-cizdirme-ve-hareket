using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class Dortgen
    {
        // Methodlar tanımlanıyor
        public Dortgen()
        {
            this.renk = ConsoleColor.Yellow;
        } //renk atarması yapıyor
        public Dortgen(int xSinir, int ySinir)
        {
            this.renk = (ConsoleColor) RastgeleSayi.SayiUret(1, 15);   //renk degeri belirleniyor
            this.xSinir = xSinir;
            this.ySinir = ySinir;
            this.genislik = RastgeleSayi.SayiUret(2, 20);//genislik degeri belirleniyor
            this.yukseklik =  RastgeleSayi.SayiUret(2, 10);  //yukseklik degeri belirleniyor
            this.x =RastgeleSayi.SayiUret(1, (xSinir - this.genislik));  //konum degeri belirleniyor
            this.y = RastgeleSayi.SayiUret(1, (ySinir - this.yukseklik));  //konum degeri belirleniyor

        }

        public void Ciz()
        { //cizim islemi yapılıyor
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = this.renk;
            this.TabanCiz();
           this.TepeCiz();
              this.DikeyCiz();
            Console.ForegroundColor = foregroundColor;
        }
        public void DikeyCiz()
        {
            //dikey cizmesi icin gerekli dongu
            for (int i = 1; i < (this.yukseklik); i++)
            {
                Console.SetCursorPosition(this.x, this.y + i);
                Console.Write(KarakterSeti.Dikey);

            }
            for (int i = 1; i < (this.yukseklik); i++)
            {
                Console.SetCursorPosition((this.x + this.genislik) - 1, this.y + i);
                Console.Write(KarakterSeti.Dikey);

            }




        }
        public void TepeCiz()
        {
            //tepe cizmesi icin gerekli dongu
           
            
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(KarakterSeti.SolUstKose);
            
            for (int i = 0; i < (this.genislik - 2); i++)
            {

                Console.Write(KarakterSeti.Duz);
            }
           Console.Write(KarakterSeti.SagUstKose);
            

        }
        public void TabanCiz()
        {
            //taban cizmesi icin gerkli dongu 
            Console.SetCursorPosition(this.x, (this.y + this.yukseklik));//y de+1 vardı
            Console.Write(KarakterSeti.SolAltKose);
            for (int i = 0; i < (this.genislik - 2); i++)
            {
                Console.Write(KarakterSeti.Duz);
            }
            Console.Write(KarakterSeti.SagAltKose);

        }
        public void KonumAta(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void BoyutAta(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public void RenkAta(ConsoleColor renk)
        {
            this.renk = renk;
        }
        public void SolaOtele()
        {
            this.x--;
        }//sola oteleme
        public void SagaOtele()
        {
            this.x++;
        }//saga  oteleme
        public void YukariOtele()
        {
            this.y--;
        }//yukari oteleme
        public void AsagiOtele()//asagı oteleme
        {
            this.y++;
        }
        // Alanlar tanımlanıyor      
        private int genislik;
        private ConsoleColor renk;
        private int x;
        private int xSinir;
        private int y;
        private int ySinir;
        private int yukseklik;

        //propertiler tanımlanıyor
        public int Genislik
        {
            get
            {
                return this.genislik;
            }
            set
            {
                this.genislik = value;
            }
        }
        public ConsoleColor Renk
        {
            get
            {
                return this.renk;
            }
            set
            {
                this.renk = value;
            }
        }
        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
        public int Yukseklik
        {
            get
            {
                return this.yukseklik;
            }
            set
            {
                this.yukseklik = value;
            }
        }
    }
}
