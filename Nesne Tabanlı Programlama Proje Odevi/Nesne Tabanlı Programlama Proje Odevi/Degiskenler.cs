using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    internal class Degiskenler
    {
    }
    public class Degisken {
        public static string email { get; set; }
        public static string password { get; set; }
        public static string yas { get; set; }
        public static string adsoyad { get; set; }
        public static string telno { get; set; }
        public static string foto{ get; set; }
        public static string acıklama{ get; set; }
        public static string rol{ get; set; }
        public static string dogrulamaKodu { get; set; }
        public static void degiskenAta(String email, string password, string telno, string yas, string adsoyad, String foto, string acıklama, string rol) {
            Degisken.email = email;
            Degisken.password = password;
            Degisken.yas = yas;
            Degisken.adsoyad = adsoyad;
            Degisken.telno = telno;
            Degisken.foto = foto;
            Degisken.acıklama = acıklama;
            Degisken.rol = rol;
        }
    }
    public class evDegisken {
        public static string odaSayisi { get; set; }
        public static string mKare { get; set; }
        public static string kiraFiyat { get; set; }
        public static string satisFiyat { get; set; }
        public static string isitmaTuru { get; set; }
        public static string esyali { get; set; }
        public static string binaTuru { get; set; }
        public static string dataGridWiewSeçilen { get; set; }
        public static void ev_Degisken_Ata(String odaSayisi, string mKare
            , string kiraFiyat, string satisFiyat
            , string isitmaTuru, String esyali, string binaTuru){
            evDegisken.odaSayisi = odaSayisi;
            evDegisken.mKare = mKare;
            evDegisken.kiraFiyat = kiraFiyat;
            evDegisken.satisFiyat = satisFiyat;
            evDegisken.isitmaTuru = isitmaTuru;
            evDegisken.esyali = esyali;
            evDegisken.binaTuru = binaTuru;
        }
    }
    public class evAdresDegisken {
        public static string id { get; set; }
        public static string sehir { get; set; }
        public static string ilce { get; set; }
        public static string mahalle { get; set; }
        public static string sokak { get; set; }
        public static string evNo { get; set; }
        public static string kat { get; set; }
        public static string daireNo { get; set; }
        public static void degiskenAta(string sehir,string ilce,
            string mahalle,string sokak,
            string evNo,string kat,string daireNo) { 
            evAdresDegisken.sehir = sehir;
            evAdresDegisken.ilce = ilce;
            evAdresDegisken.mahalle = mahalle;
            evAdresDegisken.sokak = sokak;
            evAdresDegisken.evNo = evNo;
            evAdresDegisken.kat = kat;
            evAdresDegisken.daireNo = daireNo;
        }
    }
}
