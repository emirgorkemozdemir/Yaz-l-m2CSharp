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

        
        // Bir fonksiyon açın, bu fonksiyona bir List<int> girilsin.
        // Bu listedeki en büyük sayı farkını bulun.
        // {80,3,90} => Döngüyle listedekileri tek tek alıp maximum
        // farkı buldurmanız lazım. Her ögeyi tek tek digerinden çıkarın.
        // İç içe döngü var.
        public static int max_fark(List<int> sayılar)
        {
            int max = 0;
            foreach (var tur1 in sayılar)
            {
                foreach (var tur2 in sayılar)
                {
                    if (tur1-tur2 > max)
                    {
                        max = tur1 - tur2;
                    }
                }
            }
            return max;
        }

        // Bir fonksiyon açın, bu fonksiyona bir adet sayı girilsin.
        // Sayının asal olup olmadıgını döndürün.
        // Asalsa true, degilse false.

        public static bool asal_mi(int sayı)
        {
            for (int i = 2; i < sayı; i++)
            {
                if (sayı%i==0)
                {
                    return false;
                }
            }
            
            return true;
        }

        // 10 kere sayı girdirin. Bu sayıların ortalamasını bulun.
        // Sayıların ortalaması pozitif ise true, degilse false döndürün
        public static bool ortalama_pozitif_mi()
        {
            int sonuc = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Sayı giriniz : ");
                int sayı = Convert.ToInt32(Console.ReadLine());
                sonuc += sayı;
            }

            sonuc = sonuc / 10;
            if (sonuc >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Bir metot açın, metoda bir string kelime girilsin.
        // Kelimenin tersiyle düzü aynı mı diye kontrol edin.
        // Örnegin :
        // Kelime mom ise tersiyle düzü aynıdır.
        // Tersiyle düzü aynıysa true, degilse false.
        public static bool palindrom_mu(string kelime)
        {
            string kelimenin_tersi = "";
            for (int i = kelime.Length-1; i >= 0; i--)
            {
                kelimenin_tersi += kelime[i];
            }

            if (kelime.ToLower()==kelimenin_tersi.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Bir tane metot açın. 
        // Parametre olarak List<string> ulkeler alsın.
        // Bu listenin içerisinde birden fazla aynı degerden varsa sildiren
        // metodu oluşturun.
        // {"Turkey","Turkey","Germany","Spain"}
        // {"Turkey","Turkey","Germany","Spain"}
        // Eger bir deger silindiyse ekrana deger listeden silindi yazsın.
        // iki döngü var!!!

        public static void tekrar_edeni_sil(List<string> ulkeler)
        {
            // {"Turkey","Turkey","Germany","Spain"}
            for(int i=0;i<ulkeler.Count;i++)
            {
                int sayac = 0;
                for (int j = 0; j < ulkeler.Count; j++)
                {
                    if (ulkeler[i] == ulkeler[j])
                    {
                        sayac++;
                    } 
                }

                if (sayac>=2)
                {
                    ulkeler.Remove(ulkeler[i]);
                }
            }

            foreach (var ulke in ulkeler)
            {
                Console.WriteLine(ulke);
            }
        }
    }
}
