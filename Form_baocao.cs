using MetroFramework.Forms;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Qly_KTX
{
    public partial class Form_baocao : MetroForm
    {
        public Form_baocao()
        {
            InitializeComponent();
        }

        private void Form_baocao_Load(object sender, EventArgs e)
        {
            metroSetRadioButton1.Checked = true;
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {
            Form_baocao_cb f = new Form_baocao_cb();
            f.Show();
            this.Hide();
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_main form_Main = new Form_main();
            form_Main.Show();
            this.Close();
        }
    }
}
