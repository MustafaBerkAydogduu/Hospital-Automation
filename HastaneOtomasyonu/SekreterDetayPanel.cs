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
    public partial class SekreterDetayPanel : Form
    {
        public SekreterDetayPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        public String tc;
        SqlBaglanti baglanti=new SqlBaglanti();
        private void SekreterDetayPanel_Load(object sender, EventArgs e)
           
        {
            //Sekreter Ad Soyad ve Tc nin yüklenmesi
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Sekreterler where SekreterTc=@1",baglanti.Connection());
            komut.Parameters.AddWithValue("@1",tc);
    
            SqlDataReader reader = komut.ExecuteReader();
            
            while (reader.Read()) 
            {
                lbl_sekreterAdSoyad.Text = reader[0].ToString();
                lbl_TC.Text = tc;
            }
            baglanti.Connection().Close();

           //Branşların data gride aktarılması
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Branslar "
                ,baglanti.Connection());
            sqlDataAdapter.Fill(dataTable);
            branslar_dg.DataSource = dataTable;
            baglanti.Connection().Close();

            //Doktorların data gride aktarılması
            DataTable dataTableDoktor = new DataTable();
            SqlDataAdapter doktor = new SqlDataAdapter("Select (DoktorAD+' '+DoktorSoyad) " 
                +"as DoktorAdSoyad,DoktorBrans From Doktorlar",baglanti.Connection());
            doktor.Fill(dataTableDoktor);
            doktorlar_dg.DataSource = dataTableDoktor;

            //Bransların comboboxa yüklenmesi
            SqlCommand cmd = new SqlCommand("Select BransAd from Branslar",baglanti.Connection());
            SqlDataReader  dataReader = cmd.ExecuteReader();
            while (dataReader.Read()) 
            {
                txt_brans.Items.Add(dataReader[0].ToString());
            }
        }

        private void txt_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Branşa göre doktorların çekilmesi 
            txt_doktor.Items.Clear();
            txt_doktor.Text = "";
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad from Doktorlar where DoktorBrans=@1", baglanti.Connection());
            cmd.Parameters.AddWithValue("@1", txt_brans.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_doktor.Items.Add(dr[0] + " " + dr[1]);
            }
            baglanti.Connection().Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //Randevu oluşturma kısmı
            SqlCommand cmd = new SqlCommand("insert into Randevular" +
                "(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum) " +
                "values(@tarih,@saat,@brans,@doktor,@durum)"
                ,baglanti.Connection());
            cmd.Parameters.AddWithValue("@tarih", txt_tarih.Text);
            cmd.Parameters.AddWithValue("@saat",txt_saat.Text);
            cmd.Parameters.AddWithValue("@brans",txt_brans.Text);
            cmd.Parameters.AddWithValue("@doktor",txt_doktor.Text);
            cmd.Parameters.AddWithValue("@durum",0);
            cmd.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Randevu başarıyla oluşturuldu","Bilgi",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_duyuruOlustur_Click(object sender, EventArgs e)
        {
            //Duyuru Oluşturma
            SqlCommand sqlCommand = new SqlCommand
                ("insert into Duyurular(Duyuru) values(@duyuru)",
                baglanti.Connection());
            sqlCommand.Parameters.AddWithValue("@duyuru",rc_duyuru.Text);
            sqlCommand.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btn_doktorP_Click(object sender, EventArgs e)
        {
            DoktorEkleSilGuncellePanel doktorEkleSilGuncellePanel = new DoktorEkleSilGuncellePanel();
            doktorEkleSilGuncellePanel.Show();
        }

        private void btn_bransP_Click(object sender, EventArgs e)
        {
            txt_ad bransEklemeSilmeGuncelleme =new txt_ad();
            bransEklemeSilmeGuncelleme.Show();
        }

        private void btn_randevuL_Click(object sender, EventArgs e)
        {
            RandevuGoruntulePanel randevuGoruntulePanel =new RandevuGoruntulePanel();
            randevuGoruntulePanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DuyurularPanel dp =new DuyurularPanel();
            dp.Show();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void branslar_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
