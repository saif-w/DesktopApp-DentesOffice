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
namespace Dental_Clinic_Doctor.PL
{
    public partial class MEMBRES : Form
    {
        public MEMBRES()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MEMBRES_Load(object sender, EventArgs e)
        {
            txtgender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (txtusername.Text == "" || txtpassowrd.Text == "" || txtfullname.Text == "" || txtphonenumber.Text == "" || txtemile.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال جميع البيانات");
                }
                else if (_MEMBER.member_login_update(txtusername.Text).Rows.Count > 0)
                {
                    MessageBox.Show("هذا الاسم موجود مسبقا");
                }
                else { 
                    _MEMBER.member_insert(txtusername.Text, txtpassowrd.Text, txtfullname.Text, Convert.ToDateTime(txtdate.Text), txtphonenumber.Text, txtgender.SelectedItem.ToString(), txtemile.Text, txtnotes.Text);
                    MessageBox.Show("تمت الاضافة", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
            }
            catch
            {
                MessageBox.Show("خطاء في تسجيل","خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void txtphonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.LOGIN l = new LOGIN();
            l.Show();
            this.Hide();
        }
    }
}
