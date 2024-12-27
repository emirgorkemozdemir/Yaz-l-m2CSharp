// ipucu : while ile çözülüyor
// Kullanıcı sürekli olarak sayı girecek
// Girilen sayı negatif gelene kadar, uygulama sayı istemeye devam etsin.
// Girilen sayı negatifse uygulama dursun.

Console.Write("Sayı giriniz : ");
int sayı = Convert.ToInt32(Console.ReadLine());

while (sayı>0)
{
    Console.WriteLine(sayı);
    Console.Write("Sayı giriniz : ");
    sayı = Convert.ToInt32(Console.ReadLine());
}