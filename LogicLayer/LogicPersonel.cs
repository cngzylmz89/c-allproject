using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityClass> LLPersonellistesi()
        {
            return DALPersonel.Personellistesi();
        }

        public static int LLPersonelEkle(EntityClass p)//Dalpersonel sınıfında oluşturduğumuz türden bir metotu oluşturuyoruz.
        {//şartlarımızı if ile belirtik metodu p nesnesiyl döndürüyoruz.
            if(p.Ad!=""&&p.Soyad!=""&&p.Maas>=4000&& p.Gorev.Length >= 3)
            {
               return DALPersonel.Personelekle(p);
            }
            else
            {
                return -1;
            }
        }
    }
}
