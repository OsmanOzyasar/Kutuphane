using Kutuphane;
using System;
using System.Collections.Generic;

namespace KitapKayıt
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap("Sefiller", "Viktor", "Hugo", "500", "İş Bankası");//New anahtar kelimesi, bir sınıfın yeni bir örneğini (instance) oluşturmak için kullanılır.

            DateTime kayıt = Kitap._kayıtZamanı;
            Console.WriteLine("Kayıt zamnı: " + kayıt);

            Kitap kitap1 = new Kitap();

            kitap1.KitapAdı = "Savaş ve Barış";
            kitap1.KitapYazarı = "Lev";
            kitap1.YazarSoyad = "Tolstoy";
            kitap1.Sayfa = "1440";
            kitap1.YayınEvi = "İş Bankası";

            kitap1.KonsolaYazdır();

            DateTime kayıt2 = Kitap._kayıtZamanı;
            Console.WriteLine("Kayıt zamnı: " + kayıt2);
        }
    }// class, bir nesnenin özelliklerini ve davranışlarını tanımlayan bir şablondur
}