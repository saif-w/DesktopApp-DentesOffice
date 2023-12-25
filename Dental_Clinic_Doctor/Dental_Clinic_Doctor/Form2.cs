using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dental_Clinic_Doctor.UC;
using System.IO;

namespace Dental_Clinic_Doctor
{
    public partial class Form2 : Form
    {
        OPPOINTMENT o;
        public Form2(OPPOINTMENT opp)
        {
            this.o = opp;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(new MemoryStream((byte[]) o.dataGridView1.CurrentRow.Cells[12].Value));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
