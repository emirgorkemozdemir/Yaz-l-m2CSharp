List<string> isimler = new List<string>();
isimler.Add("Emir");
isimler.Add("Ahmet");
isimler.Add("Mehmet");

// Foreach döngüsü dolaşılabilir (iteration) bir şey varsa
// orada diger döngülerden daha kolay şekilde işlemi yapabilir.

// Iteration yapılabilir ögeler => stringler, listeler, arrayler
// Dahası da var ama onları daha görmedik :)

foreach (string isim in isimler)
{
    Console.WriteLine(isim);
}