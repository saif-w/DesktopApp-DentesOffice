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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.MEMBRES M = new PL.MEMBRES();this.Hide(); ;M.Show();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text==""||txtpassowrd.Text=="")
            {
                MessageBox.Show("الرجاء ادخال اسم مستخدم وكلمة السر");
            }
            else if (_MEMBER.member_login(txtusername.Text, txtpassowrd.Text).Rows.Count==1)
            {
                Program.USERNAME = _MEMBER.member_login(txtusername.Text, txtpassowrd.Text).Rows[0][0].ToString();
                PL.main_form m = new main_form();
                m.Show();
             
                this.Hide();
            }
            else { MessageBox.Show("الرجاء التأكد من اسم المستخم او كلمة السر"); }
        }
    }
}
