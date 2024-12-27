// C#'ta listeler arraylere alternatif olarak
// daha kolay yönetilmesi için oluşturuldu. Yine birden fazla
// veri tutabilir.

List<int> sayılar = new List<int>();

// Listelere veri eklemek
sayılar.Add(5);

// Listelerden veri silmek
sayılar.Remove(5);

// Sort listeleri küçükten büyüge (artan ascending) şekilde sıralar
// Reverse yaparsam ters çevirir, dolayısıyla büyükten küçüge olur
sayılar.Sort();
sayılar.Reverse();