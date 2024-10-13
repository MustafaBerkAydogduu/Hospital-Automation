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
    public partial class DoktorEkleSilGuncellePanel : Form
    {
        public DoktorEkleSilGuncellePanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        SqlBaglanti baglanti=new SqlBaglanti();
        private void DoktorEkleSilGuncellePanel_Load(object sender, EventArgs e)
        {
            //Doktorların data gride aktarılması
            DataTable dataTableDoktor = new DataTable();
            SqlDataAdapter doktor = new SqlDataAdapter("Select * From Doktorlar", baglanti.Connection());
            doktor.Fill(dataTableDoktor);
            dg_doktorGoruntule.DataSource = dataTableDoktor;
            baglanti.Connection().Close();

            //Bransların comboboxa yüklenmesi
            SqlCommand cmd = new SqlCommand("Select BransAd from Branslar", baglanti.Connection());
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                cb_brans.Items.Add(dataReader[0].ToString());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Doktor EkLEME
            SqlCommand cmd = new SqlCommand("insert into Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@ad,@soyad,@brans,@tc,@sifre)", baglanti.Connection());
            cmd.Parameters.AddWithValue("@ad",txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad",txt_soyad.Text);
            cmd.Parameters.AddWithValue("@brans",cb_brans.Text);
            cmd.Parameters.AddWithValue("@tc",txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre",txt_sifre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Ekleme işlemi Başarılı");
            
        }

        private void dg_doktorGoruntule_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen=dg_doktorGoruntule.SelectedCells[0].RowIndex;
            txt_ad.Text = dg_doktorGoruntule.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dg_doktorGoruntule.Rows[secilen].Cells[2].Value.ToString();
            cb_brans.Text = dg_doktorGoruntule.Rows[secilen].Cells[3].Value.ToString();
            txt_tc.Text = dg_doktorGoruntule.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dg_doktorGoruntule.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("Delete From Doktorlar where DoktorTC=@1",baglanti.Connection());
            delete.Parameters.AddWithValue("@1",txt_tc.Text);
            delete.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Ekleme işlemi Başarılı");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //Doktor Güncelle
            SqlCommand cmd = new SqlCommand("Update Doktorlar set DoktorAd=@ad ,DoktorSoyad=@soyad,DoktorBrans=@brans,DoktorSifre=@sifre where DoktorTC=@tc", baglanti.Connection());
            cmd.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@brans", cb_brans.Text);
            cmd.Parameters.AddWithValue("@tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Connection().Close();
            MessageBox.Show("Güncelleme işlemi Başarılı");
        }
    }
}
