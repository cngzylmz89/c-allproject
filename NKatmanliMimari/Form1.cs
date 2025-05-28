using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;//referance ı ekle
using DataAccessLayer;//referance ı ekle
using LogicLayer;//referance ı ekle

namespace NKatmanliMimari
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perslist = LogicPersonel.LLpersonellistesi();// List<EntityPersonel> den Perslist adında bir değişken türet. LogicPersonel sınıfından oluşturduğumuz LLpersonellistesi metoduna ata.
            dataGridView1.DataSource = Perslist;//dataGridView1 in kaynağını Perslist değişkeni olarak ata.

        }
    }
}
