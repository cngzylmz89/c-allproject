using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    class DALPersonel
    {
        public static List<EntityPersonel> Personellistesi ()//EntityPersonel sınıfı kullanmak üzere listele metodu oluşturduk ve ismini Personellistesi koyduk
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();//değer döndüren bir metot olduğu için oluşturduğumuz metot sınıfı ve sınıftan bir DEGERLER adında bir nesne türetiyoruz
            SqlCommand komut = new SqlCommand("select * from TBLBİLGİ", Baglanti.bgl);//sqldeki tabloyla bağlantıyı kuruyoruz ve komutumuzu oluşturuyoruz.
            if (komut.Connection.State != ConnectionState.Open)//komut bağlantı durumu açık değilse
            {
                komut.Connection.Open();//komutun bağlantısını aç
            }

            SqlDataReader dr = komut.ExecuteReader();//tablodaki değerleri okuyacağız

            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();//EntityPersonel sınıfından nesne türetip bu nesne aracılığıyla aynı sınıfta oluşturduğumuz değişkenleri sqldeki tablonun sütunlarıyla ilişkilendiriyoruz.
                ent.ID1 = int.Parse(dr["ID"].ToString());
                ent.Ad1 = dr["AD"].ToString();
                ent.Soyad1 = dr["SOYAD"].ToString();
                ent.Sehir1 = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas1 = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);//metottan oluşturduğumuz nesneye ent den gelen değerleri aktarıyoruz.
            }
            dr.Close();//bağlantıyı kapatıyoruz
            return degerler;//degerler den gelenleri döndürüyoruz.
         }
        
    }
}
