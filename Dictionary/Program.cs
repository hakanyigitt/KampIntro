using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(28, "Hakan Yiğit");
            ogrenci.Add(53, "Eda Arıcı");
            ogrenci.Add(37, "Büşra Nur Öz");

            Console.WriteLine("Öğrenci No Giriniz: ");
            int no = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(ogrenci[no]);
            }
            catch (Exception)
            {

                Console.WriteLine("Öğrenci bulunamadı");
            }

            bool varMi = ogrenci.ContainsKey(28);
            bool varMi2 = ogrenci.ContainsValue("Hakan");
            //ogrenci.Clear(); -> tüm anahtar-değer çiftlerini siler
            int elemanSayisi = ogrenci.Count;
            //bool silindiMi = ogrenci.Remove(28); ->28 anahtarı varsa siler ve true döndürür yoksa false döndürür

        }
    }
}
