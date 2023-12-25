using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Dental_Clinic_Doctor.BL;

namespace Dental_Clinic_Doctor.REP
{
    public partial class posituve_bill : Form
    {
        public posituve_bill()
        {
            InitializeComponent();
        }

        private void posituve_bill_Load(object sender, EventArgs e)
        {
            this.opp_date_posteveTableAdapter.Fill(this.dataSet1.opp_date_posteve, Convert.ToDateTime(first.Text), Convert.ToDateTime(last.Text));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = _APP_PASTOIN.opp_date_posteve_count(Convert.ToDateTime(first.Text), Convert.ToDateTime(last.Text)).Rows[0][0].ToString() ;
            this.opp_date_posteveTableAdapter.Fill(this.dataSet1.opp_date_posteve, Convert.ToDateTime(first.Text), Convert.ToDateTime(last.Text));
            this.reportViewer1.RefreshReport();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void last_ValueChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
