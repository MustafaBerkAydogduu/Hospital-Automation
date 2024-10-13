using System;
using System.Collections.Concurrent;
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
    public partial class HastaDetayPanel : Form
    {
        public HastaDetayPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        public String tc;
        private void HastaDetayPanel_Load(object sender, EventArgs e)
        {
            lbl_TC.Text = tc;
            //Ad Soyad
            SqlCommand adSoyad=new SqlCommand("Select HastaAd,HastaSoyad from Hastalar where HastaTc="+tc, baglanti.Connection());
            SqlDataReader drAdSoyad= adSoyad.ExecuteReader();
            while (drAdSoyad.Read())
            {
                lbl_adSoyad.Text = drAdSoyad[0] + " " + drAdSoyad[1];
            }
            baglanti.Connection().Close(); 


            //Randevu Geçmişi
            DataTable dtRandevuGecmisi=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular " +
                "where HastaTc="+tc,baglanti.Connection());
            da.Fill(dtRandevuGecmisi);
            dgw_gecmişR.DataSource = dtRandevuGecmisi;


            //Branşları Çekme
            SqlCommand branslar = new SqlCommand("Select BransAd from Branslar",baglanti.Connection());
            SqlDataReader drBranslar = branslar.ExecuteReader();
            while (drBranslar.Read())
            {
                cb_brans.Items.Add(drBranslar[0]);
            }
            baglanti.Connection().Close();

        }

        private void cb_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Randevular " +
                "where RandevuBrans='"+cb_brans.Text+"' and RandevuDoktor='"+cb_doktor.Text+"' and" +
                " RandevuDurum=0",baglanti.Connection());
            sqlDataAdapter.Fill(dt);
            dgw_randevuA.DataSource = dt;
            baglanti.Connection().Close();
        }

        private void cb_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_doktor.Items.Clear();
            cb_doktor.Text = "";
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad from Doktorlar" +
                " where DoktorBrans=@1", baglanti.Connection());
            cmd.Parameters.AddWithValue("@1", cb_brans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb_doktor.Items.Add(dr[0]+" "+ dr[1]);
            }
            baglanti.Connection().Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lnkBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaGuncellePanel hastaGuncellePanel = new HastaGuncellePanel();
            hastaGuncellePanel.tc = tc;
            hastaGuncellePanel.Show();
        }

        private void dgw_randevuA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dgw_randevuA.SelectedCells[0].RowIndex;
            txt_id.Text = dgw_randevuA.Rows[secilen].Cells[0].Value.ToString();
            cb_brans.Text = dgw_randevuA.Rows[secilen].Cells[3].Value.ToString();
            cb_doktor.Text = dgw_randevuA.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btn_randevu_Click(object sender, EventArgs e)
        {
            SqlCommand randevuAl=new SqlCommand("update Randevular set RandevuDurum='True' " +
                ", HastaTC=@tc ,HastaSikayet=@sikayet " +
                "where Randevuİd=@id",baglanti.Connection());
            randevuAl.Parameters.AddWithValue("@tc", lbl_TC.Text);
            randevuAl.Parameters.AddWithValue("@sikayet", rc_sikayet.Text);
            randevuAl.Parameters.AddWithValue("@id",txt_id.Text);
            randevuAl.ExecuteNonQuery();
            MessageBox.Show("Randevu Başarılı Bir Şekilde Alınmıştır");
        }

        private void dgw_gecmişR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand randevuAl = new SqlCommand("update Randevular set RandevuDurum='False' " +
                ", HastaTC=@tc ,HastaSikayet=@sikayet where " +
                "Randevuİd=@id and HastaTC=@tc2", baglanti.Connection());
            randevuAl.Parameters.AddWithValue("@tc", "NULL");
            randevuAl.Parameters.AddWithValue("@sikayet", "NULL");
            randevuAl.Parameters.AddWithValue("@id", txt_id.Text);
            randevuAl.Parameters.AddWithValue("@tc2",lbl_TC.Text);
            randevuAl.ExecuteNonQuery();
            MessageBox.Show("Randevu Başarılı Bir Şekilde İptal edilmiştir");
        }

        private void dgw_randevuA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
