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
    public partial class DoktorGuncellePanel : Form
    {
        public DoktorGuncellePanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        public string tc;
        SqlBaglanti SqlBaglanti=new SqlBaglanti();
        private void DoktorGuncellePanel_Load(object sender, EventArgs e)
        {
            //Doktor bilgilerini çekme
            SqlCommand cmd=new SqlCommand("Select * from Doktorlar where DoktorTc="+tc,SqlBaglanti.Connection());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
                txt_ad.Text = sqlDataReader[1].ToString();
                txt_soyad.Text = sqlDataReader[2].ToString();
                cb_brans.Text = sqlDataReader[3].ToString();
                txt_tc.Text = tc;
                txt_sifre.Text = sqlDataReader[5].ToString();
           
            }
            SqlBaglanti.Connection().Close();

            //branşları comboboxa çekme

            SqlCommand branslar = new SqlCommand("Select * from Branslar", SqlBaglanti.Connection());
            SqlDataReader dr= branslar.ExecuteReader();
            while (dr.Read()) 
            {
                cb_brans.Items.Add(dr[1].ToString());
            }
            SqlBaglanti.Connection().Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand branslar = new SqlCommand("Update Doktorlar Set" +
                " DoktorAd=@ad,DoktorSoyad=@soyad,DoktorBrans=@brans,DoktorTC=@tc,DoktorSifre=@sifre" +
                " where DoktorTC=@tconay", SqlBaglanti.Connection());
            branslar.Parameters.AddWithValue("@ad",txt_ad.Text);
            branslar.Parameters.AddWithValue("@soyad",txt_soyad.Text);
            branslar.Parameters.AddWithValue("@brans",cb_brans.Text);
            branslar.Parameters.AddWithValue("@tc",txt_tc.Text);
            branslar.Parameters.AddWithValue("@sifre",txt_sifre.Text);
            branslar.Parameters.AddWithValue("@tconay", tc);
            branslar.ExecuteNonQuery();
            SqlBaglanti.Connection().Close();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
