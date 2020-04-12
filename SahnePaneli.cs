using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_161210039
{
    class SahnePaneli
    {
        public SahnePaneli(int genislik, int yukseklik)
        {
            this.cizimAlani.BoyutAta(genislik, yukseklik);//boyut atanıyor
            this.genislik = genislik;
            this.yukseklik = yukseklik;
            this.maksimumSekilSayisi = 100;//max sekil sayısı 100 olarak belirleniyor
            this.sekilSayisi = 0;
            this.sekiller = new Dortgen[this.maksimumSekilSayisi];//sekiller diziye atanıyor
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
                this.aktifSekil.Ciz();
            }
            for (int i = 0; i < this.sekilSayisi; i++)
            {
                this.sekiller[i].Ciz();
            }
        }//ciz methodu
        public void AktifSekilAta(Dortgen yeniSekil)
        {
            if ((this.aktifSekil != null) && (this.sekilSayisi < 100))
            {
                this.sekiller[this.sekilSayisi] = this.aktifSekil;
                this.sekilSayisi++;
            }
            this.aktifSekil = yeniSekil;
        }//sartlar saflanıyor ise aktif sekil atayan method
        public void SekilSolaOtele()
        {
            if (this.aktifSekil.X > 1)
            {
                this.aktifSekil.SolaOtele();
                if (this.SekillerCarpisiyormu())
                {
                    this.aktifSekil.SagaOtele();
                }
            }
        }//oteleme islemi
        public void SekilSagaOtele()
        {
            if ((this.aktifSekil.X + this.aktifSekil.Genislik) < (this.genislik - 1))
            {
                this.aktifSekil.SagaOtele();
                if (this.SekillerCarpisiyormu())
                {
                    this.aktifSekil.SolaOtele();
                }
            }
        }//oteleme islemi
        public void SekilYukariOtele()
        {
            if (this.aktifSekil.Y > 1)
            {
                this.aktifSekil.YukariOtele();
                if (this.SekillerCarpisiyormu())
                {
                    this.aktifSekil.AsagiOtele();
                }
            }
        }//oteleme islemi
        public void SekilAsagiOtele()
        {
            if ((this.aktifSekil.Y + this.aktifSekil.Yukseklik) < (this.yukseklik - 1))
            {
                this.aktifSekil.AsagiOtele();
                if (this.SekillerCarpisiyormu())
                {
                    this.aktifSekil.YukariOtele();
                }
            }
        }//oteleme islemi
        public bool SekillerCarpisiyormu()
        {
            for (int i = 0; i < this.sekilSayisi; i++)
            {
                if ((((this.aktifSekil.X < (this.sekiller[i].X + this.sekiller[i].Genislik)) && ((this.aktifSekil.X + this.aktifSekil.Genislik) > this.sekiller[i].X)) && (this.aktifSekil.Y < (this.sekiller[i].Y + this.sekiller[i].Yukseklik))) && ((this.aktifSekil.Y + this.aktifSekil.Yukseklik) > this.sekiller[i].Y))
                {
                    return true;
                }
            }
            return false;
        }//sekillerin carpısma durumunu kontrol eden kod 

        //alanler
        private int genislik;
        private int yukseklik;
        private int x;
        private int y;
        private Dortgen cizimAlani = new Dortgen();
        private Dortgen aktifSekil = new Dortgen();
        private int sekilSayisi;
        private int maksimumSekilSayisi;
        private Dortgen[] sekiller;

    }
}
