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
    public partial class DoktorDetayPanel : Form
    {
        public DoktorDetayPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        public string tc;
        private void button2_Click(object sender, EventArgs e)
        {
            DuyurularPanel duyurularPanel = new DuyurularPanel();
            duyurularPanel.Show();
        }
        SqlBaglanti conn = new SqlBaglanti();
        private void DoktorDetayPanel_Load(object sender, EventArgs e)
        {
            //tc ve ad soyadın ekrana getirilmesi
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad from Doktorlar where DoktorTc="+tc,conn.Connection());
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbl_doktorAdSoyad.Text = sqlDataReader[0]+" "+sqlDataReader[1];
                lbl_TC_doktor.Text = tc;
            }
            conn.Connection().Close();

            //Data gride doktorun randevularını aktarma
            DataTable dataTable = new DataTable();
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * From Randevular where RandevuDoktor='Kemal Cihan'", conn.Connection());
            sorgu.Fill(dataTable);
            dgw_gecmişR.DataSource = dataTable;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_bilgiD_Click(object sender, EventArgs e)
        {
            DoktorGuncellePanel doktorGuncellePanel = new DoktorGuncellePanel();
            doktorGuncellePanel.tc= tc;
            doktorGuncellePanel.Show();
        }

        private void dgw_gecmişR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dgw_gecmişR.SelectedCells[0].RowIndex;
            txt_siakyet.Text=dgw_gecmişR.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
