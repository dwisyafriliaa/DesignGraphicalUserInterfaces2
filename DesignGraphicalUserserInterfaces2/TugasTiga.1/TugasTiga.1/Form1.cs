using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga._1
{
    public partial class frmTugas : Form
    {
        public frmTugas()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "NIM       :  20.11.3665";
            lblNama.Text = "Nama   :  DWI SYAFRILIA";
            lblKelas.Text = "Kelas    :  20 IF 06";
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            lblNIM.Text = "NIM       :  ";
            lblNama.Text = "Nama   :  ";
            lblKelas.Text = "Kelas    :  ";
        }
    }
}
