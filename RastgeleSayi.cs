using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Kullanmak icin tek yapmaniz gereken asagidaki gibi cagri yapmaktri
//RastgeleSayi.SayiUret(1,100);
//yukaridaki cagri 1 ile 100 arasinda rastgele bir sayi uretecektir

namespace G_161210039
{
    class RastgeleSayi
    {
        public static int SayiUret(int min, int max)
        {
            if (rastgele == null)
                rastgele = new Random();

            return rastgele.Next(min, max);
        }

        private static Random rastgele;
    }
}
