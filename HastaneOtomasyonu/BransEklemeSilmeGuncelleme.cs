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
    public partial class txt_ad : Form
    {
        public txt_ad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        SqlBaglanti conn= new SqlBaglanti();
        private void txt_ad_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("Select * From Branslar",conn.Connection());
            sqlCommand.Fill(dt);
            dgw_branslar.DataSource=dt;
            
        }

        private void dgw_branslar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen=dgw_branslar.SelectedCells[0].RowIndex;
            txt_id.Text = dgw_branslar.Rows[secilen].Cells[0].Value.ToString();
            txt_soyad.Text = dgw_branslar.Rows[secilen].Cells[1].Value.ToString();
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Branslar (BransAd) values(@bransad)",conn.Connection());
            cmd.Parameters.AddWithValue("@bransad",txt_soyad.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branş ekleme işlemi başarılı");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Branslar where Bransid=@1", conn.Connection());
            cmd.Parameters.AddWithValue("@1",txt_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branş silme işlemi başarılı");
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Branslar set BransAd=@2 where Bransid=@1", conn.Connection());
            cmd.Parameters.AddWithValue("@1",txt_id.Text);
            cmd.Parameters.AddWithValue("@2",txt_soyad.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branş Güncelleme işlemi başarılı");
        }

        private void dgw_branslar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
