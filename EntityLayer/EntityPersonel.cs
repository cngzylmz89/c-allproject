using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityPersonel
    {
        int ID;
        string Ad;
        string Soyad;
        string Sehir;
        string gorev;
        short Maas;

        public int ID1 { get => ID; set => ID = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Sehir1 { get => Sehir; set => Sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas1 { get => Maas; set => Maas = value; }
    }
}
