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
    public partial class DoktorGirisPanel : Form
    {
        public DoktorGirisPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void DoktorGirisPanel_Load(object sender, EventArgs e)
        {

        }
        SqlBaglanti b = new SqlBaglanti();
        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand("Select * From Doktorlar " +
                "where Doktortc=@tc and" +
                " DoktorSifre=@sifre"
                ,b.Connection());
            cmd.Parameters.AddWithValue("@tc",txt_tc.Text);
            cmd.Parameters.AddWithValue("@sifre",txt_sifre.Text);
            SqlDataReader r=cmd.ExecuteReader();
            if (r.Read()) 
            {
                DoktorDetayPanel doktorDetayPanel = new DoktorDetayPanel();
                doktorDetayPanel.tc = txt_tc.Text;
                doktorDetayPanel.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
        }

        private void txt_tc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
