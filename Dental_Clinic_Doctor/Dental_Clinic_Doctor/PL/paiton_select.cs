using Dental_Clinic_Doctor.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Doctor.PL
{
    public partial class paiton_select : Form
    {
        UC.OPPOINTMENT op;
        public paiton_select(UC.OPPOINTMENT o)
        {
            this.op = o;
            InitializeComponent();
        }
        void load()
        {
            dataGridView1.DataSource = _PATIENT._SELECTE("");
        }
        private void paiton_select_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _PATIENT._SELECTE(txtserach.Text);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            op.txtid_paiton.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            op.txtbox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // op.textBox1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //op.comboBox1.DataSource = _PATIENT.selcet_PATIENT_chose();
            //op.comboBox1.DisplayMember = "FULLNAME";
            //op.comboBox1.ValueMember = "ID";
          //  op.comboBox1.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Hide();
        }
    }
}
