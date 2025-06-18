using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaporala_Oyunu
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno, dogru, yanlıs;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SIRADAKİ SORU";
            soruno++;

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye karasının ismi nedir?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İskender yemeğinin en iyi yapıldığı ilimiz hangisidir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Tarihin gördüğü en büyük hükümdar hangisidir?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Bir baltık ülkesi";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "İskender yemeğinin en iyi yapıldığı ilimiz hangisidir?";
                button2.BackColor = Color.Yellow;
            }
        }
    }
}
