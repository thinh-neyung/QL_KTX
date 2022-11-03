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
    public partial class Form_baocao_cb : MetroForm
    {
        KetNoi_CSDL kn = new KetNoi_CSDL();
        public Form_baocao_cb()
        {
            InitializeComponent();
        }

        private void Form_baocao_cb_Load(object sender, EventArgs e)
        {
            string sql = "select * from can_bo";
            CrystalReport_cb report = new CrystalReport_cb();
            report.SetDataSource(kn.LayDuLieu(sql));
            crystalReportViewer1.ReportSource = report;
        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            Form_baocao form_Main = new Form_baocao();
            form_Main.Show();
            this.Close();
        }
    }
}
