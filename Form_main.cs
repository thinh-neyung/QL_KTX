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
    public partial class Form_main : MetroForm
    {
        public Form_main()
        {
            InitializeComponent();
        }

        

        private void vbButton1_Click(object sender, EventArgs e)
        {
            Form_canbo form_Canbo = new Form_canbo();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton2_Click(object sender, EventArgs e)
        {
            Form_sinhvien form_Canbo = new Form_sinhvien();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton3_Click(object sender, EventArgs e)
        {
            Form_khu form_Canbo = new Form_khu();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_Phong form_Canbo = new Form_Phong();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton5_Click(object sender, EventArgs e)
        {
            Form_LoaiDichvu form_Canbo = new Form_LoaiDichvu();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton6_Click(object sender, EventArgs e)
        {
            Form_Login form_Canbo = new Form_Login();
            form_Canbo.Show();
            this.Hide();
        }
        private void vbButton7_Click(object sender, EventArgs e)
        {
            Form_baocao form_Canbo = new Form_baocao();
            form_Canbo.Show();
            this.Hide();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }
    }
}
