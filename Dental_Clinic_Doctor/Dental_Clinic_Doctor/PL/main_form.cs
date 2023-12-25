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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void patient1_Load(object sender, EventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {
            label1.Text = Program.USERNAME;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //patient1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //docters1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //oppointment1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            docters2.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            patient2.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            oppointment2.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Program.close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            UC.OPPOINTMENT z = new UC.OPPOINTMENT();
            z.kk();
            apP_PASTOIN1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                this.Hide();
                PL.LOGIN l = new LOGIN();
                l.Show();
            }
            else { string cxc = ""; }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
          //  REP.opp_serachX n = new REP.opp_serachX();
            n.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            REP.posituve_bill p = new REP.posituve_bill();
            p.Show();
        }

        private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
        {
            REP.nagtev_form n = new REP.nagtev_form();
            n.Show();
        }

        private void bunifuFlatButton9_Click_1(object sender, EventArgs e)
        {
            REP.opp_serachX n = new REP.opp_serachX();
            n.Show();

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            if (panel_slid.Height == 0)
            {
                panel_slid.Height = 167;
            }
            else
            {
                panel_slid.Height = 0;
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            REP.posituve_bill p = new REP.posituve_bill();
            p.Show();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            update_member_password_form m = new update_member_password_form();
            m.Show();

        }
    }
}
