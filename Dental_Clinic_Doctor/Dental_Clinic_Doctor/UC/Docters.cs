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
    public partial class Docters : UserControl
    {
        public Docters()
        {
            InitializeComponent();
        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadress_TextChanged(object sender, EventArgs e)
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
        void load()
        {
            dataGridView1.DataSource = _DOCTOR._SELECTE("");
        }
        private void Docters_Load(object sender, EventArgs e)
        {
            txtgender.SelectedIndex = 0;
            txtQUALIFIDDOCTOR.SelectedIndex = 0;

           load();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdategrouditon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDATEOFAPPOINTTED_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _DOCTOR._SELECTE(txtserach.Text);
        }
        string user1 = Program.USERNAME; string date = DateTime.Now.ToString("dd/MM/yyyy").ToString();
        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtfullname.Text == "" || txtbirthdate.Text == "" || txtemile.Text == "" || txtphonenumber.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال جميع البيانات");
                }
                else
                {
                    _DOCTOR._insert(txtfullname.Text, Convert.ToDateTime(txtbirthdate.Text), txtgender.Text, txtQUALIFIDDOCTOR.SelectedItem.ToString(), txtdategrouditon.Value.ToString(), txtDATEOFAPPOINTTED.Value.ToString(), txtphonenumber.Text, txtemile.Text, txtnotes.Text, Convert.ToDateTime(date), user1);
                    load();
                clean();
                MessageBox.Show("تمت الاضافة");
                }
            }
            //catch { }
            //}

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                txtfullname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtbirthdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtphonenumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtemile.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               
                txtnotes.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtQUALIFIDDOCTOR.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtgender.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtdategrouditon.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtDATEOFAPPOINTTED.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
        }
        void clean()
        {
            txtemile.Text = "";
            txtfullname.Text = "";
            txtnotes.Text = "";
            txtphonenumber.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfullname.Text == "" || txtbirthdate.Text == "" || txtemile.Text == "" || txtphonenumber.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال جميع البيانات");
                }
                else if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    _DOCTOR._update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txtfullname.Text, Convert.ToDateTime(txtbirthdate.Text),txtgender.Text ,txtQUALIFIDDOCTOR.SelectedItem.ToString(), txtdategrouditon.Value.ToString(), txtDATEOFAPPOINTTED.Value.ToString(), txtphonenumber.Text, txtemile.Text, txtnotes.Text, Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()), user1);
                    load();
                    MessageBox.Show("تمت تعديل");
                }
            }
            catch { }
        }
    }
}