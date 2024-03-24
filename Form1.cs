using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ecczane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/eczane.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eczaneDataSet.eczane' table. You can move, or remove it, as needed.
            this.eczaneTableAdapter.Fill(this.eczaneDataSet.eczane);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                MessageBox.Show("baglantı acıldı");
                baglantı.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad, tur;
            int fiyat, adet;
            ad = textBox1.Text;
            tur = textBox2.Text;
            fiyat = Convert.ToInt16(textBox3.Text);
            adet = Convert.ToInt16(textBox4.Text);
        

            try
            {
                baglantı.Open();
                OleDbCommand komut = new OleDbCommand("insert into eczane(ad,tur,fiyat,adet)VALUES('" + ad + "','" + tur + "','" + fiyat + "','" + adet + "')", baglantı);
          
        }
    }
}
