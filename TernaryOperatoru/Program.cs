using System;

namespace TernaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "";
            string sifre = "";

            Console.WriteLine("Kullanıcı adini gir: ");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifreyi gir: ");
            sifre = Console.ReadLine();

            string durum = (kullaniciAdi == "Admin" && sifre == "12345") ? "Giriş başarılı" : "Kullanıcı adı veya şifre hatalı";
            Console.WriteLine(durum);

            bool girisDurum = (kullaniciAdi == "Admin" && sifre == "12345") ? true : false;
            Console.WriteLine(girisDurum);
        }
    }
}
