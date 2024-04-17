using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATmUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            // Yapmak istediğini işlemi sor
            // 1- Bakiye Görüntüleme
            // 2- Para Çekme
            // 3- Para Yatırma
            // q ya basarsa çıkış yaptıracağız

            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");

            Console.WriteLine("1 - Bakiye Sorgulama");
            Console.WriteLine("2 - Para Çekme ");
            Console.WriteLine("3 - Para Yatırma");
            Console.WriteLine("q - Çıkış");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz:" + bakiye);

            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                int cekilecek_tutar = int.Parse(Console.ReadLine());
                Console.WriteLine("Kalan Tutar: " + (bakiye - cekilecek_tutar));

            }

            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak İsdtediğiniz Tutarı Giriniz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Şuanki Bakiyeniz:" + (bakiye + yatırılacak_tutar));


            }
            else if (secim == "q")
            {
                Console.WriteLine("Çıkış Yapılıyor..." );
                Console.WriteLine("İYİ GÜNLER");

               Console.ReadLine();  
            }
            Console.ReadLine();
           
        }    
    }
    
}
