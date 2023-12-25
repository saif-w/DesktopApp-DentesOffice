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
using Dental_Clinic_Doctor.PL;
namespace Dental_Clinic_Doctor.UC
{
    public partial class APP_PASTOIN : UserControl
    {
        public APP_PASTOIN()
        {
            InitializeComponent();
        }
    //    DataTable dt= _APP_PASTOIN.APPPASOIN_SELECTE("");
       public void load()
        {
          
            dataGridView1.DataSource = _APP_PASTOIN.APPPASOIN_SELECTE("");
          
          
        }
        void row_color()
        {
            double x;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                x = Convert.ToDouble(_APP_PASTOIN.APPPASOIN_SELECTE("").Rows[i][2].ToString());
                if (x > 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (x == 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }
        private void APP_PASTOIN_Load(object sender, EventArgs e)
        {
            load();
            button2.Enabled = false;    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            row_color();
        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _APP_PASTOIN.APPPASOIN_SELECTE(txtserach.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcoleter a = new calcoleter(this);
            a.Show();
        }
       

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {

                string id_payment = _APP_PASTOIN.zz_SELECTE(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).Rows[0][0].ToString();
                button2.Enabled = true;
                 dataGridView2.DataSource = _APP_PASTOIN.qualty_SELECTE(Convert.ToInt32(id_payment)); 
                

                try
                {
                }
                catch
                {

                }
            }
        }
    }
}
