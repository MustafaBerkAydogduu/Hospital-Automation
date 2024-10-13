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
    public partial class SekreterGirisPanel : Form
    {
        public SekreterGirisPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        SqlBaglanti conn=new SqlBaglanti();
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * From Sekreterler " +
                "where SekreterTC=@1 and " +
                "SekreterSifre=@2",conn.Connection());
            sqlCommand.Parameters.AddWithValue("@1",txt_tc.Text);
            sqlCommand.Parameters.AddWithValue("@2",txt_sifre.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                SekreterDetayPanel sekreterDetayPanel = new SekreterDetayPanel();
                sekreterDetayPanel.tc=txt_tc.Text;
                sekreterDetayPanel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre","bilgi",MessageBoxButtons.OK
                    ,MessageBoxIcon.Warning);
            }
        
        }

        private void SekreterGirisPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
