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
    }
}
