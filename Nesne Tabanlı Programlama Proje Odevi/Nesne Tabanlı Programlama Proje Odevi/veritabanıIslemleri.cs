using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace Nesne_Tabanlı_Programlama_Proje_Odevi
{
    internal class veritabanıIslemleri
    {
    }
    public class KisiVeritabanı
    {
        public ArrayList dizi = new ArrayList();
        public static String constring = (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "EmlakProje.mdf;Integrated Security = True");
        SqlConnection baglan = new SqlConnection(constring);
        Database db = new Database();
        DataTable dt = new DataTable();
        public void kisi_Ekle(String email, String sifre, String telno, String age, String adSoyad, String profilFoto = "")
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                #region// kisiler veritabanında kullanıcının kaydı yapılıyor
                String kayit = "insert into kisiler (email,sifre,telno,yas,adsoyad,profilfoto,aciklama,rol) " +
                    "values(@eposta,@password,@telno,@age,@fullname,@profil,'','')";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@eposta", email);
                komut.Parameters.AddWithValue("@password", sifre);
                komut.Parameters.AddWithValue("@telno", telno);
                komut.Parameters.AddWithValue("@age", age);
                komut.Parameters.AddWithValue("@fullname", adSoyad);
                komut.Parameters.AddWithValue("@profil", profilFoto);
                komut.ExecuteNonQuery();
                #endregion
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kişi eklenemedi");
            }
        }
        public bool kisi_Sil(String eposta)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                #region Delete from kisiler database
                String silKisi = ("delete  from kisiler where email = @eposta");
                SqlCommand komutKisiSil = new SqlCommand(silKisi, baglan);
                komutKisiSil.Parameters.AddWithValue("@eposta", eposta);
                komutKisiSil.ExecuteNonQuery();
                #endregion
                #region Delete from ev database
                String silEv = ("delete from ev where email = @eposta");
                SqlCommand komutevSil = new SqlCommand(silEv, baglan);
                komutevSil.Parameters.AddWithValue("@eposta", eposta);
                komutevSil.ExecuteNonQuery();
                #endregion
                #region Delete from evadres database
                String silEvAdres = ("delete from evadres where email = @eposta");
                SqlCommand komutEvAdresSil = new SqlCommand(silEvAdres, baglan);
                komutEvAdresSil.Parameters.AddWithValue("@eposta", eposta);
                komutEvAdresSil.ExecuteNonQuery();
                #endregion
                #region Delete from evfoto database
                String silEvFoto = ("delete from evfoto where email = @eposta");
                SqlCommand komutEvFotoSil = new SqlCommand(silEvFoto, baglan);
                komutEvFotoSil.Parameters.AddWithValue("@eposta", eposta);
                komutEvFotoSil.ExecuteNonQuery();
                #endregion
                baglan.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Kisi Silinemedi", MessageBoxButtons.OK);
                return false;
            }
        }
        public void mail_Guncelle(String eposta, String eskiPosta) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                #region Update mail kisiler database
                String kisi_Mail_Guncelle = ("Update kisiler set email = @yeniEposta where email = @email");
                SqlCommand komutKisiMail = new SqlCommand(kisi_Mail_Guncelle, baglan);
                komutKisiMail.Parameters.AddWithValue("@yeniEposta", eposta);
                komutKisiMail.Parameters.AddWithValue("@email", eskiPosta);
                komutKisiMail.ExecuteNonQuery();
                #endregion
                #region Update mail ev database
                String ev_Mail_Guncelle = ("Update ev set email = @yeniEposta where email = @email");
                SqlCommand komutEvMail = new SqlCommand(ev_Mail_Guncelle, baglan);
                komutEvMail.Parameters.AddWithValue("@yeniEposta", eposta);
                komutEvMail.Parameters.AddWithValue("@email", eskiPosta);
                komutEvMail.ExecuteNonQuery();
                #endregion
                #region Update mail evadres database
                String evadres_Mail_Guncelle = ("Update evadres set email = @yeniEposta where email = @email");
                SqlCommand komutEvAdresMail = new SqlCommand(evadres_Mail_Guncelle, baglan);
                komutEvAdresMail.Parameters.AddWithValue("@yeniEposta", eposta);
                komutEvAdresMail.Parameters.AddWithValue("@email", eskiPosta);
                komutEvAdresMail.ExecuteNonQuery();
                #endregion
                #region Update mail evfoto database
                String evfoto_Mail_Guncelle = ("Update evfoto set email = @yeniEposta where email = @email");
                SqlCommand komutEvFotoMail = new SqlCommand(evfoto_Mail_Guncelle, baglan);
                komutEvFotoMail.Parameters.AddWithValue("@yeniEposta", eposta);
                komutEvFotoMail.Parameters.AddWithValue("@email", eskiPosta);
                komutEvFotoMail.ExecuteNonQuery();
                #endregion
                baglan.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Mail Güncellenemedi", MessageBoxButtons.OK);
            }
        }
        public void telno_Guncelle(String eposta, String telno) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                String kisi_Guncelle = ("Update kisiler set telno = @tel where email = @email");
                SqlCommand komut = new SqlCommand(kisi_Guncelle, baglan);
                komut.Parameters.AddWithValue("@tel", telno);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Telefon numarası güncellenemedi");
            }
        }
        public void sifre_Guncelle(String eposta, String sifre)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                String kisi_Guncelle = ("Update kisiler set sifre = @sifre where email = @email");
                SqlCommand komut = new SqlCommand(kisi_Guncelle, baglan);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Şifre Değiştirilemedi");
            }
        }
        public void foto_Guncelle(String eposta, String path) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                String kisi_Guncelle = ("Update kisiler set profilfoto = @foto where email = @email");
                SqlCommand komut = new SqlCommand(kisi_Guncelle, baglan);
                komut.Parameters.AddWithValue("@foto", path);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "fotoğrafınız güncellenemedi");
            }

        }
        public void adsoyad_Guncelle(String eposta, String adsoyad) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                String kisi_Guncelle = ("Update kisiler set adsoyad = @isim where email = @email");
                SqlCommand komut = new SqlCommand(kisi_Guncelle, baglan);
                komut.Parameters.AddWithValue("@isim", adsoyad);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.ExecuteNonQuery();
                baglan.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Ad Soyad Değiştirilemedi");
            }
        }
        public void yas_Guncelle(String eposta, String age) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                String kisi_Guncelle = ("Update kisiler set yas = @yas where email = @email");
                SqlCommand komut = new SqlCommand(kisi_Guncelle, baglan);
                komut.Parameters.AddWithValue("@yas", age);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.ExecuteNonQuery();
                baglan.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Yaş Değiştirilemedi");
            }

        }
        public bool kisiler_Ara(int satırno, String arananDeger)
        {
            dt.Clear();
            dt = db.readData("select * from kisiler", "");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][satırno].ToString().Equals(arananDeger))
                {
                    for (int j = 0; j < 8; j++)
                    {
                        dizi.Add(dt.Rows[i][j].ToString());
                    }
                    return true;
                }
            }
            return false;
        }
    }
    public class evVeriTabanı {
        public ArrayList dizi = new ArrayList();
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        Database db = new Database();
        DataTable dt = new DataTable();
        public void evEkle(String id, String odasayisi, String mkare, String kirafiyat, String satisfiyat, string isitmaturu, string esyali, String binaturu)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String kayit = "insert into ev(Id,email,odasayisi,mkare" +
                        ",kirafiyat,satisfiyat,isitmaturu,esyali,binaturu) values" +
                        " (@id,@email,@odasayisi,@mkare,@kirafiyat" +
                        ",@satisfiyat,@isitmaturu,@esyali,@binaturu)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@email", Degisken.email);
                    komut.Parameters.AddWithValue("@odasayisi", odasayisi);
                    komut.Parameters.AddWithValue("@mkare", mkare);
                    komut.Parameters.AddWithValue("@kirafiyat", kirafiyat);
                    komut.Parameters.AddWithValue("@satisfiyat", satisfiyat);
                    komut.Parameters.AddWithValue("@isitmaturu", isitmaturu);
                    komut.Parameters.AddWithValue("@esyali", esyali);
                    komut.Parameters.AddWithValue("@binaturu",binaturu);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Ekleme hatası");
            }
        }
        public void evSil(string id) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                #region Delete from ev database
                String silEv = ("delete from ev where Id = @id");
                SqlCommand komutevSil = new SqlCommand(silEv, baglan);
                komutevSil.Parameters.AddWithValue("@id", id);
                komutevSil.ExecuteNonQuery();
                #endregion
                #region Delete from evadres database
                String silEvAdres = ("delete from evadres where Id = @id");
                SqlCommand komutEvAdresSil = new SqlCommand(silEvAdres, baglan);
                komutEvAdresSil.Parameters.AddWithValue("@id", id);
                komutEvAdresSil.ExecuteNonQuery();
                #endregion
                #region Delete from evfoto database
                String silEvFoto = ("delete from evfoto where Id = @id");
                SqlCommand komutEvFotoSil = new SqlCommand(silEvFoto, baglan);
                komutEvFotoSil.Parameters.AddWithValue("@id", id);
                komutEvFotoSil.ExecuteNonQuery();
                #endregion
                #region Delete from evlistele Database
                String silEvliste = ("delete from evlistele where Id = @id");
                SqlCommand komutEvlisteSil = new SqlCommand(silEvliste, baglan);
                komutEvlisteSil.Parameters.AddWithValue("@id", id);
                komutEvlisteSil.ExecuteNonQuery();
                #endregion
                baglan.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev silinemedi");
            }
        }
        public void evDegerGüncelle(String id, String odasayisi, String mkare, String kirafiyat
            , String satisfiyat, string isitmaturu, string esyali, String binaturu) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String kayit = "update ev set odasayisi = @odasayisi,mkare = @mkare" +
                        ",kirafiyat = @kirafiyat,satisfiyat = @satisfiyat,isitmaturu = @isitmaturu" +
                        ",esyali = @esyali,binaturu = @binaturu where Id = @id";
                    SqlCommand komut = new SqlCommand(kayit, baglan);                    
                    komut.Parameters.AddWithValue("@odasayisi", odasayisi);
                    komut.Parameters.AddWithValue("@mkare", mkare);
                    komut.Parameters.AddWithValue("@kirafiyat", kirafiyat);
                    komut.Parameters.AddWithValue("@satisfiyat", satisfiyat);
                    komut.Parameters.AddWithValue("@isitmaturu", isitmaturu);
                    komut.Parameters.AddWithValue("@esyali", esyali);
                    komut.Parameters.AddWithValue("@binaturu", binaturu);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Değer güncelleme hatası");
            }
        }
        public int id_Cek() {
            dt.Clear();
            dt = db.readData("select * from ev","");
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            dt.Clear();
            dt = db.readData("select MAX(Id) from ev", "");
            return Convert.ToInt32(dt.Rows[0][0].ToString())+1;
        }
    }
    public class evAdresVeritabanı
    {
        public ArrayList dizi = new ArrayList();
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        Database db = new Database();
        DataTable dt = new DataTable();
        public void evAdresEkle(String id, String sehir, String ilce, String mahalle, String sokak
            , string evNo, string kat, String daireNo)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String kayit = "insert into evadres(Id,sehir,ilce,mah,sokak,evno,kat,daireno,email) values" +
                        " (@id,@sehir,@ilce,@mahalle,@sokak,@evNo,@kat,@daireNo,@email)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@sehir", sehir);
                    komut.Parameters.AddWithValue("@ilce", ilce);
                    komut.Parameters.AddWithValue("@mahalle", mahalle);
                    komut.Parameters.AddWithValue("@sokak", sokak);
                    komut.Parameters.AddWithValue("@evNo", evNo);
                    komut.Parameters.AddWithValue("@kat", kat);
                    komut.Parameters.AddWithValue("@daireNo", daireNo);
                    komut.Parameters.AddWithValue("@email",Degisken.email);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Adres ekleme sorunu");
            }
        }
        public void evAdresGüncelle(String id, String sehir, String ilce, String mahalle, String sokak
            , string evNo, string kat, String daireNo) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                baglan.Open();
                String kayit = "update evadres set sehir = @sehir,ilce = @ilce,mah = @mahalle" +
                    ",sokak = @sokak,evno = @evNo,kat = @kat,daireno = @daireNo where Id = @id";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@sehir", sehir);
                komut.Parameters.AddWithValue("@ilce", ilce);
                komut.Parameters.AddWithValue("@mahalle", mahalle);
                komut.Parameters.AddWithValue("@sokak", sokak);
                komut.Parameters.AddWithValue("@evNo", evNo);
                komut.Parameters.AddWithValue("@kat", kat);
                komut.Parameters.AddWithValue("@daireNo", daireNo);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Adres güncelleme sorunu");
            }
        }
        public bool evAdresAra(int satırno,String arananDeger) {
            dt.Clear();
            dt = db.readData("select * from evadres","");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][satırno].ToString().Equals(arananDeger))
                {
                    return true;
                }
            }
            return false;
        }
    }
    public class evFotoVeriTabanı {
        string kayıt = "";
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        public void fotoSil(string id) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string sil = "delete from evfoto where Id = @id";
                    SqlCommand komut = new SqlCommand(sil, baglan);
                    komut.Parameters.AddWithValue("@id",id);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }catch (SqlException ex) 
            {
                MessageBox.Show(ex.ToString());
            }
                    
        
        
        }
        public void fotoEkle(string id,ArrayList dizi) {
            if (dizi.Count == 0 || dizi.Count > 10)
            {
                return;
            }
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                SqlCommand komut = new SqlCommand(kayıt, baglan);
                switch (dizi.Count)
                {
                    #region 1 foto
                case 1:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                     "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                     " (@id,@p1,'','','','','','','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString()); 
                    goto case 11;
                    #endregion
                    #region 2 foto
                case 2:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,'','','','','','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    goto case 11;
#endregion
                    #region 3 foto
                case 3:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,'','','','','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    goto case 11;
#endregion
                    #region 4 foto
                case 4:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                     "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                     " (@id,@p1,@p2,@p3,@p4,'','','','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    goto case 11;
#endregion
                    #region 5 foto
                case 5:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,'','','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    goto case 11;
#endregion
                    #region 6 foto
                case 6:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,@p6,'','','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    komut.Parameters.AddWithValue("@p6", dizi[5].ToString());
                    goto case 11;
                #endregion
                    #region 7 foto
                case 7:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,@p6,@p7,'','','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    komut.Parameters.AddWithValue("@p6", dizi[5].ToString());
                    komut.Parameters.AddWithValue("@p7", dizi[6].ToString());
                    goto case 11;
#endregion
                    #region 8 foto
                case 8:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,'','',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    komut.Parameters.AddWithValue("@p6", dizi[5].ToString());
                    komut.Parameters.AddWithValue("@p7", dizi[6].ToString());
                    komut.Parameters.AddWithValue("@p8", dizi[7].ToString());
                    goto case 11;
                #endregion
                    #region 9 foto
                case 9:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,'',@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id",id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    komut.Parameters.AddWithValue("@p6", dizi[5].ToString());
                    komut.Parameters.AddWithValue("@p7", dizi[6].ToString());
                    komut.Parameters.AddWithValue("@p8", dizi[7].ToString());
                    komut.Parameters.AddWithValue("@p9", dizi[8].ToString());
                    goto case 11;
#endregion
                    #region 10 foto
                case 10:
                    kayıt = "insert into evfoto(Id,evfoto1,evfoto2,evfoto3," +
                    "evfoto4,evfoto5,evfoto6,evfoto7,evfoto8,evfoto9,evfoto10,email)values" +
                    " (@id,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@mail)";
                    komut = new SqlCommand(kayıt, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@p1", dizi[0].ToString());
                    komut.Parameters.AddWithValue("@p2", dizi[1].ToString());
                    komut.Parameters.AddWithValue("@p3", dizi[2].ToString());
                    komut.Parameters.AddWithValue("@p4", dizi[3].ToString());
                    komut.Parameters.AddWithValue("@p5", dizi[4].ToString());
                    komut.Parameters.AddWithValue("@p6", dizi[5].ToString());
                    komut.Parameters.AddWithValue("@p7", dizi[6].ToString());
                    komut.Parameters.AddWithValue("@p8", dizi[7].ToString());
                    komut.Parameters.AddWithValue("@p9", dizi[8].ToString());
                    komut.Parameters.AddWithValue("@p10", dizi[9].ToString());
                    goto case 11;
                #endregion
                    case 11:
                        komut.Parameters.AddWithValue("@mail",Degisken.email);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "fotoğraf eklenemedi");
            }


        }
    }
    public class evlisteleVeritabanı {
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        public void evListeEkle(String id, String sehir, String ilce, String mahalle
            , String odasayisi, String mkare, String kirafiyat, String satisfiyat)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    #region evadres veritabanında kullanıcının evi kaydediliyor
                    String kayit = "insert into evlistele(Id,sehir,ilce,mah,odasayisi," +
                        "mkare,kiralikfiyat,satisfiyat,email) values" +
                        " (@id,@sehir,@ilce,@mah,@odasayisi,@mkare,@kirafiyat" +
                        ",@satisfiyat,@email)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@sehir", sehir);
                    komut.Parameters.AddWithValue("@ilce", ilce);
                    komut.Parameters.AddWithValue("@mah", mahalle);
                    komut.Parameters.AddWithValue("@odasayisi", odasayisi);
                    komut.Parameters.AddWithValue("@mkare", mkare);
                    komut.Parameters.AddWithValue("@kirafiyat", kirafiyat);
                    komut.Parameters.AddWithValue("@satisfiyat", satisfiyat);
                    komut.Parameters.AddWithValue("@email", Degisken.email);
                    komut.ExecuteNonQuery();
                    #endregion
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Listeleme veritabanına eklenemedi");
            }
        }
        public void evListeDegerGüncelle(String id, String odasayisi, String mkare,
            String kirafiyat, String satisfiyat) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "update evlistele set odasayisi = @odasayisi,mkare = @mkare" +
                        ",kiralikfiyat = @kirafiyat,satisfiyat = @satisfiyat where Id = @id";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@odasayisi", odasayisi);
                    komut.Parameters.AddWithValue("@mkare", mkare);
                    komut.Parameters.AddWithValue("@kirafiyat", kirafiyat);
                    komut.Parameters.AddWithValue("@satisfiyat", satisfiyat);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Listeleme veritabanı güncellenemedi");
            }
        }
        public void evListeAdresGüncelle(String id, String sehir, String ilce, String mahalle) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    
                    string kayit = "update evlistele set sehir = @sehir,ilce = @ilce,mah = @mahalle where Id = @id";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.Parameters.AddWithValue("@sehir", sehir);
                    komut.Parameters.AddWithValue("@ilce", ilce);
                    komut.Parameters.AddWithValue("@mahalle", mahalle);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ev Listeleme veritabanı güncellenemedi");
            }
        }
    }
    public class evVeriCek {
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlDataAdapter dataAdapter2 = new SqlDataAdapter();
        public static ArrayList evVeriler = new ArrayList();
        public static ArrayList evAdresVeriler = new ArrayList();
        public static ArrayList evFotoVeriler = new ArrayList();
        static int i;
        public void veriCek (string id)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String ev = "select isitmaturu,esyali,binaturu from ev where Id = @id";
                    SqlCommand komut = new SqlCommand(ev, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    dataAdapter.SelectCommand = komut;
                    dataAdapter.Fill(dt);
                    evVeriler.Add(dt.Rows[0][0].ToString());
                    evVeriler.Add(dt.Rows[0][1].ToString());
                    evVeriler.Add(dt.Rows[0][2].ToString());
                    dt.Clear();
                    komut.ExecuteNonQuery();
                    string evadres = "select mah,sokak,evno,kat,daireno from evadres where Id = @id";
                    SqlCommand komut2 = new SqlCommand(evadres, baglan);
                    komut2.Parameters.AddWithValue("@id", id);
                    dataAdapter2.SelectCommand = komut2;
                    dataAdapter2.Fill(dt2);
                    evAdresVeriler.Add(dt2.Rows[0][0].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][1].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][2].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][3].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][4].ToString());
                    dt2.Clear();
                    komut2.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ev Liste verisi çekilemedi");
            }
        }
        public void evAdresCek(string id) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string evadres = "select * from evadres where Id = @id";
                    SqlCommand komut = new SqlCommand(evadres, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    dataAdapter2.SelectCommand = komut;
                    dataAdapter2.Fill(dt2);
                    evAdresVeriler.Add(dt2.Rows[0][1].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][2].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][3].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][4].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][5].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][6].ToString());
                    evAdresVeriler.Add(dt2.Rows[0][7].ToString());
                    dt2.Clear();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ev diğer veriler çekilemedi");
            }
        }
        public void evDegercek(string id) 
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String ev = "select * from ev where Id = @id";
                    SqlCommand komut = new SqlCommand(ev, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    dataAdapter.SelectCommand = komut;
                    dataAdapter.Fill(dt);
                    evVeriler.Add(dt.Rows[0][2].ToString());
                    evVeriler.Add(dt.Rows[0][3].ToString());
                    evVeriler.Add(dt.Rows[0][4].ToString());
                    evVeriler.Add(dt.Rows[0][5].ToString());
                    evVeriler.Add(dt.Rows[0][6].ToString());
                    evVeriler.Add(dt.Rows[0][7].ToString());
                    evVeriler.Add(dt.Rows[0][8].ToString());
                    dt.Clear();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ev adres verisi çekilemedi");
            }
            
        }
        public void evFotoCek(string id) {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    dt.Clear();
                    String ev = "select * from evfoto where Id = @id";
                    SqlCommand komut = new SqlCommand(ev, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    dataAdapter.SelectCommand = komut;
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        return;
                    }
                    for (i = 1; i < 11; i++)
                    {
                        if (dt.Rows[0][i].ToString().Equals(""))
                        {
                            i--;
                            break;
                        }
                    }
                    switch (i)
                    {
                        case 10:
                            evFotoVeriler.Add(dt.Rows[0][10].ToString());
                            goto case 9;
                        case 9:
                            evFotoVeriler.Add(dt.Rows[0][9].ToString());
                            goto case 8;
                        case 8:
                            evFotoVeriler.Add(dt.Rows[0][8].ToString());
                            goto case 7;
                        case 7:
                            evFotoVeriler.Add(dt.Rows[0][7].ToString());
                            goto case 6;
                        case 6:
                            evFotoVeriler.Add(dt.Rows[0][6].ToString());
                            goto case 5;
                        case 5:
                            evFotoVeriler.Add(dt.Rows[0][5].ToString());
                            goto case 4;
                        case 4:
                            evFotoVeriler.Add(dt.Rows[0][4].ToString());
                            goto case 3;
                        case 3:
                            evFotoVeriler.Add(dt.Rows[0][3].ToString());
                            goto case 2;
                        case 2:
                            evFotoVeriler.Add(dt.Rows[0][2].ToString());
                            goto case 1;
                        case 1:
                            evFotoVeriler.Add(dt.Rows[0][1].ToString());
                            break;
                    }
                    dt.Clear();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ev foto verisi çekilemedi");
            }
        }
    }
    public class kisiVeriCek {
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        public static string mail;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public static ArrayList list = new ArrayList();
        public void mailCek(string id)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String ev = "select email from evlistele where Id = @id";
                    SqlCommand komut = new SqlCommand(ev, baglan);
                    komut.Parameters.AddWithValue("@id", id);
                    da.SelectCommand = komut;
                    da.Fill(dt);
                    mail = dt.Rows[0][0].ToString();
                    dt.Clear();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mail Çekildi verisi çekilemedi");
            }
        }
        public void kisiVeriCekMaileGore() 
        {
            kisiVeriCek.list.Clear();
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    String ev = "select * from kisiler where email = @mail";
                    SqlCommand komut = new SqlCommand(ev, baglan);
                    komut.Parameters.AddWithValue("@mail", mail);
                    da.SelectCommand = komut;
                    da.Fill(dt);
                    list.Add(dt.Rows[0][4].ToString());
                    list.Add(dt.Rows[0][0].ToString());
                    list.Add(dt.Rows[0][2].ToString());
                    list.Add(dt.Rows[0][3].ToString());
                    list.Add(dt.Rows[0][5].ToString());
                    dt.Clear();
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mail Çekildi verisi çekilemedi");
            }
        }
        }
    public class kontrol {
        public bool sifreKontrol(String sifre)
        {
            String[] rakamlar = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            char[] chars = {'!','£','#','^','+','$','%','½','&','/','{','(','[',')',']','=','}','?','*','_','-',
                '|','é','.',':',';',',','`','@','€','ß','æ','<','>'};
            char[] bharfler = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M','N','O','Ö','P','R','S','Ş',
                'T','U','Ü','V','Y','Z','X','Q'};
            String[] kharfler = new string[bharfler.Length];
            for (byte i = 0; i < kharfler.Length; i++)
            {
                kharfler[i] = (bharfler[i].ToString().ToLower());
            }
            byte rakam = 0, krktr = 0, bharf = 0, kharf = 0;
            if (sifre.Length > 5 && sifre.Length <= 20)
            {
                for (byte i = 0; i < sifre.Length; i++)
                {
                    foreach (string sayi in rakamlar)
                    {
                        if (sifre.Substring(i, 1) == sayi)
                        {
                            rakam++;
                        }
                    }
                    foreach (char chr in chars)
                    {
                        if (sifre.Substring(i, 1) == chr.ToString())
                        {
                            krktr++;
                        }
                    }
                    foreach (char degerb in bharfler)
                    {
                        if (sifre.Substring(i, 1) == degerb.ToString())
                        {
                            bharf++;
                        }
                    }
                    foreach (string degerk in kharfler)
                    {
                        if (sifre.Substring(i, 1) == degerk)
                        {
                            kharf++;
                        }
                    }
                }
                if ((rakam + krktr + bharf + kharf) == sifre.Length)
                {
                    if (rakam != 0 && krktr != 0 && bharf != 0 && kharf != 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sifreniz en az 1 adet karakter,büyük harf,küçük harf ve rakamdan oluşmalıdır. ", "Şifre kombinasyon hatası");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Sifrenizde geçersiz karakter bulunmaktadır. ", "geçersiz karakter hatası");
                    return false;

                }

            }
            else
            {
                MessageBox.Show("Sifreniz en az 6 karakterden oluşmalıdır", "Şifre uzunluk hatası");
                return false;
            }
        }
        public bool epostaKontrol(String ePosta)
        {
            if (ePosta.EndsWith("@gmail.com") || ePosta.EndsWith("@yandex.com") || ePosta.EndsWith("@hotmail.com") || ePosta.EndsWith("@outlook.com"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("E-posta sonu @gmail.com,@outlook.com,@yandex.com ya da @hotmail.com şeklinde bitmelidir", "domain desteklenmiyor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool telnoKontrol(String telno) {
            char[] a = telno.ToCharArray();
            foreach (char item in a)
            {
                if (char.IsLetter(item))
                {
                    MessageBox.Show("Telefon numaranızda sayı dışında karakter girdiniz\n Lütfen kontrol edip tekrar deneyin");
                    return false;
                }
            }
            if (telno.Length != 11 || !(telno.StartsWith("0")))
            {
                MessageBox.Show("Telefon numaranız 0 ile başlayıp 11 haneli olmalıdır.\nSadece rakamlardan oluşmalıdır.\n örnek (054********)", "Telefon numarası hatalı girildi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }   
    }
    public class mail_Gonder
    {
        public static bool gonder(string konu, string icerik, String mail)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("saffetcan5665@gmail.com".ToString());
            ePosta.To.Add(mail.ToString());
            ePosta.Subject = konu;
            ePosta.Body = icerik;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("saffetcan5665@gmail.com".ToString(), "mtnldxzupeumigqp".ToString());
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com".ToString();
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(ePosta);
                return true;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                return false;
            }
        }
    }
    public class Ayarla {
        public static string metinGirSadece(string metin,int sınır)
        {
            char[] temp = new char[metin.Length];
            temp = metin.ToCharArray();
            foreach (char item in temp)
            {
                if (char.IsLetter(item))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Lütfen sadece harf giriniz");
                    metin = metin.Substring(0, metin.Length - 1);
                    break;
                }
            }
            if (metin.Length > sınır)
            {
                metin = metin.Substring(0, sınır);
            }
            return metin;
        }
        public static string dogrulamaKodu(string kod) {
            char[] temp = new char[kod.Length];
            temp = kod.ToCharArray();
            foreach (char item in temp)
            {
                if (char.IsDigit(item))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Lütfen sadece sayı giriniz");
                    kod = kod.Substring(0, kod.Length - 1);
                    break;
                }
            }
            if (kod.Length > 6)
            {
                kod = kod.Substring(0, 6);
            }
            return kod;
        }
        public static string sınırlıSayıGir(string sayı,int sınır) 
        {
            char[] temp = new char[sayı.Length];
            temp = sayı.ToCharArray();
            foreach (char item in temp)
            {
                if (char.IsDigit(item))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Lütfen sadece sayı giriniz");
                    sayı = sayı.Substring(0, sayı.Length - 1);
                    break;
                }
            }
            if (sayı.Length > sınır)
            {
                sayı = sayı.Substring(0, sınır);
            }
            return sayı;
        }
    }
    public class veriListeleme {
        SqlConnection baglan = new SqlConnection(KisiVeritabanı.constring);
        DataSet ds = new DataSet();
        public DataSet diğerlerini_Listele(string mail) {
            string ifade = "select Id,sehir,ilce,mah,odasayisi,mkare,kiralikfiyat,satisfiyat from evlistele where email != @email";
            SqlCommand komut = new SqlCommand(ifade, baglan);
            komut.Parameters.AddWithValue("@email", mail);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(ds);
            return ds;
        }
        public DataSet listeleMaileGore(string mail) {
            string ifade = "select Id,sehir,ilce,mah,odasayisi,mkare,kiralikfiyat,satisfiyat from evlistele where email = @email";
            SqlCommand komut = new SqlCommand(ifade,baglan);
            komut.Parameters.AddWithValue("@email",mail);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(ds);
            return ds;
        
        }

    }
}
