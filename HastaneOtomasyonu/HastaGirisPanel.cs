using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class HastaGirisPanel : Form
    {
        public HastaGirisPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void lnklbl_uyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayitPanel hkp=new HastaKayitPanel();
            hkp.Show();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
     
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            SqlCommand giris=new SqlCommand("Select * From Hastalar where HastaTc=@tc and HastaSifre=@sifre", baglanti.Connection());
            giris.Parameters.AddWithValue("@tc",txt_tc.Text);    
            giris.Parameters.AddWithValue("@sifre",txt_sifre.Text);
            SqlDataReader reader=giris.ExecuteReader();
            if (reader.Read())
            {
                HastaDetayPanel hastaDetayPanel = new HastaDetayPanel();
                hastaDetayPanel.tc=txt_tc.Text;
                hastaDetayPanel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            baglanti.Connection().Close();

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HastaGirisPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
