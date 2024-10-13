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
    public partial class DuyurularPanel : Form
    {
        public DuyurularPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void DuyurularPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneDataSet1.Duyurular' table. You can move, or remove it, as needed.
            this.duyurularTableAdapter.Fill(this.hastaneDataSet1.Duyurular);
            // TODO: This line of code loads data into the 'hastaneDataSet.Randevular' table. You can move, or remove it, as needed.
            this.randevularTableAdapter.Fill(this.hastaneDataSet.Randevular);

        }
    }
}
