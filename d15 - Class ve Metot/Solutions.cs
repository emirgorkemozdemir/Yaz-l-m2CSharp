using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d15___Class_ve_Metot
{
    public class Solutions
    {
        // Classın içindeki metot aslında şablon gibi, yani sayı yerine
        // herhangi bir int deger girebilir.
        public static int ikitkatı(int sayı)
        {
            // void yerine işlemin sonucu ne olacaksa onu yazıyoruz.
            return sayı * 2;
        }

        // Bir metot oluşturun, bu metoda bir sayı girilsin. Bu sayının karesini
        // döndürün ve Program.cs'te kullanın
        public static int kare(int sayı)
        {
            return sayı * sayı;
        }

        // Metoda girilen 3 adet notun, en büyügunu bulan uygulama. Döngü var !
        public static int maxbul(List<int> notlar)
        {
            int maxdeger = 0;
            foreach (int not in notlar) 
            {          
                if (not>maxdeger)
                {
                    maxdeger = not;
                }
            }

            return maxdeger;
        }

        // Bir metot açın, metoda 1 tane vize, 1 tane final puanı gelsin.
        // Vize'nin yüzde 40'ını , finalin yüzde 60'ını alıp ikisini toplayın.
        // Bu bizim ortalama puanımız olacak bunu return yapın.
        public static double nothesapla(double vize,double final)
        {
            double vizeninhesabı = vize * 40 / 100;
            double finalinhesabı = final * 60 / 100;
            return vizeninhesabı + finalinhesabı;
        }

        // Bir fonksiyon oluşturun, fonksiyona string bir kelime girilsin.
        // Bu kelimenin içerisindeki sesli harflerin sayısını return etsin.
        public static int sesliharfsay(string kelime)
        {
            string sesliler = "aeıiouAEIİOU";
            int sayac = 0;

            foreach (char karakter in kelime)
            {
                if (sesliler.Contains(karakter))
                {
                    sayac++;
                }
            }

            return sayac;
        }

        // Bir fonksiyon açın, bir kelime ve bir sayı girilsin.
        // Bu kelimenin her harfini girilen sayı kadar çogaltın.
        // Yeni kelimeyi döndürün.
        // emir , 2 => eemmiirr
        public static string harfarttır(string kelime,int tekrar)
        {
            string sonuc = "";
            foreach (char karakter in kelime)
            {
                for (int i = 0; i < tekrar; i++)
                {
                    sonuc += karakter;
                }
            }

            return sonuc;
        }
    }
}
