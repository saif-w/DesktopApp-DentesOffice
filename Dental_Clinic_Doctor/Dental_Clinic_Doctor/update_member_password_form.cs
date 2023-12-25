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
namespace Dental_Clinic_Doctor
{
    public partial class update_member_password_form : Form
    {
        public update_member_password_form()
        {
            InitializeComponent();
        }

        private void update_member_password_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                string user = Program.USERNAME;
                if (txtfullname.Text == "" || txtpassowrd.Text == "")
                {
                    MessageBox.Show("الرجاء تعبأت جميع البيانات");
                }
                else
                {
                    if (txtfullname.Text == txtpassowrd.Text)
                    {
                        _MEMBER.member_update_00(user, txtpassowrd.Text);
                        MessageBox.Show("تم التعديل");
                    }
                    else
                    {
                        MessageBox.Show("يجب ان تكون القيم متشابها");
                    }
                }
                
            }
            else
            {
                string zvzv = "";
            }
        }
    }
}
