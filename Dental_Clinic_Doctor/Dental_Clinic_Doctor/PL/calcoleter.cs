using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental_Clinic_Doctor.BL;
using Dental_Clinic_Doctor.UC;
namespace Dental_Clinic_Doctor.PL
{
    public partial class calcoleter : Form
    {
        APP_PASTOIN a;
        public calcoleter(APP_PASTOIN ap)
        {
            this.a = ap;
            InitializeComponent();
        }
       
        public void calcoleter_Load(object sender, EventArgs e)
        {
            string x = a.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string y = a.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_1.Text = y.ToString();
        }

        private void txt_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }

        private void txt_2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_2.Text == "")
            {
                MessageBox.Show("ادخال قيمة السداد");
            }
            else 
            {
                Double z = Convert.ToDouble(txt_1.Text) - Convert.ToDouble(txt_2.Text);
                txt_3.Text = z.ToString();
            }
         
        }
        string user1 = Program.USERNAME;
        private void button2_Click(object sender, EventArgs e)
        {
             string date = DateTime.Now.ToString("dd/MM/yyyy").ToString();
            if (Convert.ToDouble(txt_3.Text) < 0)
            {
                MessageBox.Show("اارجاء عدم ادخال قيم سالبة");
            }
            else if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {  
                    string x = a.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string y = a.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //string id_payment = a.dataGridView1.CurrentRow.Cells[1].Value.ToString();
               string id_payment = _APP_PASTOIN.zz_SELECTE(Convert.ToInt32(x)).ToString();
                id_payment = _APP_PASTOIN.zz_SELECTE(Convert.ToInt32(a.dataGridView1.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
                _APP_PASTOIN._SELECTE_calolater(Convert.ToInt32(x), txt_3.Text);
                  _APP_PASTOIN.qualty_insert(Convert.ToInt32(id_payment), txt_1.Text, txt_2.Text, txt_3.Text, Convert.ToDateTime(date), user1);
              
                MessageBox.Show("تم التعديل");
                this.Hide();
                a.load();
            }
            else { String GDG = ""; }
        }
    }
}
