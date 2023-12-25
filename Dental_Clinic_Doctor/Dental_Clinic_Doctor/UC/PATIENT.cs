using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental_Clinic_Doctor.BL;
namespace Dental_Clinic_Doctor.UC
{
    public partial class PATIENT : UserControl
    {
        public PATIENT()
        {
            InitializeComponent();
        }
        private void PATIENT_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
           dataGridView1.DataSource= _PATIENT._SELECTE("");  
        }
        string date = DateTime.Now.ToString("dd/MM/yyyy").ToString();

        private void txtnotes_TextChanged(object sender, EventArgs e)
        {

        }
        void clean()
        {
            txtadress.Text = "";
            txtemile.Text = "";
            txtfullname.Text = "";
            txtnotes.Text = "";
            txtphonenumber.Text = "";
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _PATIENT._SELECTE(txtserach.Text);
        }
        string user1 = Program.USERNAME;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfullname.Text == "" || txtbirthdate.Text == "" || txtemile.Text == "" ||  txtphonenumber.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال جميع البيانات");
                }
                else
                {
                    _PATIENT._insert(txtfullname.Text, Convert.ToDateTime(txtbirthdate.Text), txtphonenumber.Text, txtemile.Text, txtadress.Text, txtnotes.Text, Convert.ToDateTime(date),user1);
                    load(); clean();
                    MessageBox.Show("تمت الاضافة");
                }

            }
            catch
            {
                MessageBox.Show("يوجد مشكلة الرجاء اعادة المحاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfullname.Text == "" || txtbirthdate.Text == "" || txtemile.Text == "" || txtphonenumber.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال جميع البيانات");
                }
                else if  (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    {
                    _PATIENT._update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),txtfullname.Text, Convert.ToDateTime(txtbirthdate.Text), txtphonenumber.Text, txtemile.Text, txtadress.Text, txtnotes.Text, Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString()), user1.ToString());
                    load();
                    MessageBox.Show("تمت تعديل");
                }

            }
            catch
            {
                MessageBox.Show("يوجد مشكلة الرجاء اعادة المحاولة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                txtfullname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtbirthdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtphonenumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                 txtemile.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtadress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtnotes.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
        }

      
        private void PATIENT_Load_2(object sender, EventArgs e)
        {
            load();
        }

        private void PATIENT_Load_1(object sender, EventArgs e)
        {
            load();
        }
    }
}
