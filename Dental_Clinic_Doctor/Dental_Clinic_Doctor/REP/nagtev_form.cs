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
    public partial class nagtev_form : Form
    {
        public nagtev_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.opp_date_negatveTableAdapter.Fill(this.dataSet1.opp_date_negatve, textBox1.Text);
            this.reportViewer1.RefreshReport();

        }

        private void nagtev_form_Load(object sender, EventArgs e)
        {
            this.opp_date_negatveTableAdapter.Fill(this.dataSet1.opp_date_negatve, "");
            this.reportViewer1.RefreshReport();

        }
    }
}
