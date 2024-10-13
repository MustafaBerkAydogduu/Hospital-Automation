using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class AnaGirisPanel : Form
    {
        public AnaGirisPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGirisPanel doktorGirisPanel = new DoktorGirisPanel();
            doktorGirisPanel.Show();
            this.Hide();
        }

        private void AnaGirisPanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            HastaGirisPanel hasta = new HastaGirisPanel();
            hasta.Show();
            this.Hide();
        }

        private void btn_sekreter_Click(object sender, EventArgs e)
        {
            SekreterGirisPanel sekreterGirisPanel = new SekreterGirisPanel();
            sekreterGirisPanel.Show();
            this.Hide();
        }
    }
}
