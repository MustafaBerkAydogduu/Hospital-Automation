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
    public partial class HastaGuncellePanel : Form
    {
        public HastaGuncellePanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        public String tc;
        String id;
        SqlBaglanti SqlBaglanti=new SqlBaglanti();
        private void HastaGuncellePanel_Load(object sender, EventArgs e)
        {
            txt_tc.Text = tc;
            SqlCommand veriGetir= new SqlCommand("Select * From Hastalar where HastaTc=@1",SqlBaglanti.Connection());
            veriGetir.Parameters.AddWithValue("@1",tc);
            SqlDataReader dr= veriGetir.ExecuteReader();    
            while (dr.Read())
            {
                id= dr[0].ToString();
                txt_ad.Text = dr[1].ToString(); 
                txt_soyad.Text = dr[2].ToString(); 
                txt_tc.Text = dr[3].ToString(); 
                txt_tel.Text = dr[4].ToString(); 
                txt_sifre.Text = dr[5].ToString(); 
                txt_cinsiyet.Text = dr[6].ToString(); 
            }
            SqlBaglanti.Connection().Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("Update Hastalar Set HastaAd=@1,HastaSoyad=@2,HastaTelefon=@4,HastaSifre=@5,HastaCinsiyet=@6 where Hastaid=@id", SqlBaglanti.Connection());
            guncelle.Parameters.AddWithValue("@1",txt_ad.Text);    
            guncelle.Parameters.AddWithValue("@2",txt_soyad.Text);     
            guncelle.Parameters.AddWithValue("@4",txt_tel.Text);    
            guncelle.Parameters.AddWithValue("@5",txt_sifre.Text);    
            guncelle.Parameters.AddWithValue("@6",txt_cinsiyet.Text);    
            guncelle.Parameters.AddWithValue("@id",id);   
            guncelle.ExecuteNonQuery();
            SqlBaglanti.Connection().Close();
            MessageBox.Show("Güncelleme işlemi başari ile gerçekleşmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
