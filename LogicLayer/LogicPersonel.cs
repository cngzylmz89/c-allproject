using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;//referance kütüphanesini ekliyoruz
using DataAccessLayer;//referance kütüphanesini ekliyoruz

namespace LogicLayer
{
     public class LogicPersonel
    {
        public static List<EntityPersonel> LLpersonellistesi()//Entitypersonel sınıfından list metodu oluşturuyoruz
        {
            return DALPersonel.Personellistesi();//metotta DALPERSONEL sınıfında oluşturduğumuz Personellistesi metodunu çağırıyoruz.
        }

        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad1 != "" && p.Soyad1 != "" && p.Sehir1 != "" && p.Maas1 >= 4000 && p.Gorev.Length >= 3)
            {
                return DALPersonel.PersonelEkleme(p);
            }
            else
            {
                return -1;
            }
        }

    }
}
