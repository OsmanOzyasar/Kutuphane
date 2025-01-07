using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap
    {
        public Kitap() { } //Constructor, bir sınıfın örneği oluşturulurken otomatik olarak çalışan, sınıfın başlangıç değerlerini ayarlayan özel bir metottur.

        private string? _kitapAdı;
        private string? _kitapYazarı;
        private string? _yazarSoyadı;
        private string? _sayfa;
        private string? _yayınevi;
        public static DateTime _kayıtZamanı = DateTime.Now;

        public string? KitapAdı { get { return _kitapAdı; } set { _kitapAdı = value; } } //Property, bir sınıfın alanlarını (field) dışarıya güvenli bir şekilde açan ve okuma/yazma işlemleri yapan özel bir özelliktir.
        public string? KitapYazarı { get { return _kitapYazarı; } set { _kitapYazarı = value; } }
        public string? YazarSoyad { get { return _yazarSoyadı; } set { _yazarSoyadı = value; } }
        public string? Sayfa { get { return _sayfa; } set { _sayfa = value; } }
        public string? YayınEvi { get { return _yayınevi; } set { _yayınevi = value; } }
        public Kitap(string kitapAdı, string kitapYazarı, string yazarSoyadı, string sayfa, string yayınevi)
        {
            _kitapAdı = kitapAdı;
            _kitapYazarı = kitapYazarı;
            _yazarSoyadı = yazarSoyadı;
            _sayfa = sayfa;
            _yayınevi = yayınevi;

            Console.WriteLine($"{kitapAdı} /{kitapYazarı} {yazarSoyadı}/ {sayfa} sayfa / {yayınevi} yayınevi");
        }//Constructor, bir sınıfın örneği oluşturulurken otomatik olarak çalışan, sınıfın başlangıç değerlerini ayarlayan özel bir metottur.

        public void KonsolaYazdır()
        {
            Console.WriteLine($"{_kitapAdı} /{_kitapYazarı} {_yazarSoyadı}/ {_sayfa} sayfa / {_yayınevi} yayınevi");
        }
    }

}
