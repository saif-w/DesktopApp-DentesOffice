using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Doctor.UC
{
    public partial class HOME : UserControl
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Restore r = new PL.Restore();
            r.Show();
        }
    }
}
