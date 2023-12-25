using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Doctor.REP
{
    public partial class opp_serachX : Form
    {
        public opp_serachX()
        {
            InitializeComponent();
        }

        private void opp_serachX_Load(object sender, EventArgs e)
        {
            this.opp_serachTableAdapter.Fill(this.dataSet1.opp_serach, "");
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.opp_serachTableAdapter.Fill(this.dataSet1.opp_serach, textBox1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
