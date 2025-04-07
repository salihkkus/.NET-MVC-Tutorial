using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje5.Models
{
    public static class StatikVeritabani
    {
        private static List<Ders> _dersler{ get; set; }
        static StatikVeritabani(){

            _dersler = new List<Ders>(){

            new Ders(){
                Adi="Matematik",
                Id=1,
                DersResmi="matematik.jpeg",
                DersKisaAciklama="Sayısal",
                DersAciklamasi="Matematik, evrenin çalışma düzeni ve mantığıdır."

            },
            new Ders(){
                Adi="Türkçe",
                Id=2,
                DersResmi="turkce.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bu ders türk dilinin anlaşılmasını ve öğrenmesini hedefler."
            },
            new Ders(){
                Adi="Teknoloji Tasarım",
                Id=3,
                DersResmi="teknoloji.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Bilgisayar anlatır."
            },
            new Ders(){
                Adi="Tarih",
                Id=4,
                DersResmi="tarih.jpeg",
                DersKisaAciklama="Sözel bir ders",
                DersAciklamasi="Tarih dersi."
            }
        };
        }

        public static List<Ders> DersleriGetir(){
            return _dersler = new List<Ders>();
        }

        public static Ders IdyeGoreGetir(int id){
            Ders? ders = _dersler.FirstOrDefault(x=>x.Id==id);

            return ders;
            }

        public static void Ekle(Ders ders){
            _dersler.Add(ders);
        }

         public static void Sil(Ders ders){
            _dersler.Remove(ders);
        }
        
    }
}