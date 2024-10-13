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
    public partial class HastaKayitPanel : Form
    {
        public HastaKayitPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void HastaKayitPanel_Load(object sender, EventArgs e)
        {

        }

        SqlBaglanti baglanti=new SqlBaglanti();
        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            SqlCommand kayit=new SqlCommand("insert into Hastalar " +
                "(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) " +
                "values(@ad,@soyad,@tc,@telefon,@sifre,@cinsiyet)"
                ,baglanti.Connection());
            kayit.Parameters.AddWithValue("@ad",txt_ad.Text);
            kayit.Parameters.AddWithValue("@soyad",txt_soyad.Text);
            kayit.Parameters.AddWithValue("@tc",txt_tc.Text);
            kayit.Parameters.AddWithValue("@telefon",txt_tel.Text);
            kayit.Parameters.AddWithValue("@sifre",txt_sifre.Text);
            kayit.Parameters.AddWithValue("@cinsiyet",txt_cinsiyet.Text);
            kayit.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Başarı ile Kayıt Oldunuz","Bilgi",MessageBoxButtons.OK
                ,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
