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
    public class DALPersonel
    {
        public static List<EntityClass> Personellistesi()
        {
            List<EntityClass> degerler = new List<EntityClass>();
            SqlCommand komut1 = new SqlCommand("select * from TBLBILGI", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityClass ent = new EntityClass();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);   
            }
            dr.Close();
            return degerler;
            
        }

        public static int Personelekle(EntityClass p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD, SOYAD, SEHIR, GOREV, MAAS) VALUES (@P1, @P2,@P2,@P4, @P5 )", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@P1", p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Sehir);
            komut2.Parameters.AddWithValue("@P4", p.Gorev);
            komut2.Parameters.AddWithValue("@P5", short.Parse(p.Maas.ToString()));

            return komut2.ExecuteNonQuery();

        }

    }
}
