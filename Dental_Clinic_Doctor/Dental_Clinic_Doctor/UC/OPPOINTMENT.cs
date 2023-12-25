using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dental_Clinic_Doctor.BL;
using System.Windows.Forms;
using System.IO;

namespace Dental_Clinic_Doctor.UC
{
    public partial class OPPOINTMENT : UserControl
    {


        public OPPOINTMENT()
        {
            InitializeComponent();
            //pictureBox1.DoubleClick += pictureBox1_DoubleClick;
        }

        private void txtfullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char s = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != s)
            {
                e.Handled = true;
            }
        }

        void load()
        {

            dataGridView1.DataSource = _OPPOINTMENT.APPPASOIN_SELECTE("");
        }
        string user1 = Program.USERNAME; string date = DateTime.Now.ToString("dd/MM/yyyy").ToString();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (pictureBox1.Image != null)
                {      //تحديد الصورة
                    MemoryStream MS = new MemoryStream();
                    pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
                    byte[] IMAGE = MS.ToArray();




                    if (txt_bill.Text == ""||txtid_paiton.Text==""||txtid_docter.Text=="")
                    {
                        MessageBox.Show("الرجاء ادخال جميع البيانات");
                    }


                    //****************************************
                    //في حالة المريض تم اضافته
                    else if (_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows.Count > 0)
                    {
                        if (txt_bullstuts.SelectedItem == "تم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "لم يتم الدفع")
                        {
                            //جمع المبلغ السابق مع المبلغ الحالي المتوب في  نص المبلغ
                            Double x = Convert.ToDouble(_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows[0][1]) + Convert.ToDouble(txt_bill.Text);

                            string x1 = x.ToString();
                            _OPPOINTMENT._update_bill(Convert.ToInt32(txtid_paiton.Text)
                                , x1);

                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "قيمة ناقصة")
                        {
                            Double x = Convert.ToDouble(_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows[0][1]) + Convert.ToDouble(txt_bill.Text);
                            string x1 = x.ToString();
                            _OPPOINTMENT._update_bill(Convert.ToInt32(txtid_paiton.Text)
                                , x1);

                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }

                    }

                    //********************************************

                    //في حالة المريض لم يقم باضافته من قبل 
                    else if (_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows.Count == 0)
                    {
                        if (txt_bullstuts.SelectedItem == "تم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            _APP_PASTOIN.APPPASOINr_insert("0", Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "لم يتم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            _APP_PASTOIN.APPPASOINr_insert(txt_bill.Text, Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "قيمة ناقصة")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "I");
                            _APP_PASTOIN.APPPASOINr_insert(txt_bill.Text, Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }

                        //***********

                    }
                }
                else
                { //تحديد الصورة
                    byte[] IMAGE = new byte[4];



                    if (txt_bill.Text == "" || txtid_paiton.Text == "" || txtid_docter.Text == "")
                    {
                        MessageBox.Show("الرجاء ادخال جميع البيانات");
                    }


                    //****************************************
                    //في حالة المريض تم اضافته
                    else if (_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows.Count > 0)
                    {
                        if (txt_bullstuts.SelectedItem == "تم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "لم يتم الدفع")
                        {
                            //جمع المبلغ السابق مع المبلغ الحالي المتوب في  نص المبلغ
                            Double x = Convert.ToDouble(_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows[0][1]) + Convert.ToDouble(txt_bill.Text);

                            string x1 = x.ToString();
                            _OPPOINTMENT._update_bill(Convert.ToInt32(txtid_paiton.Text)
                                , x1);

                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "قيمة ناقصة")
                        {
                            Double x = Convert.ToDouble(_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows[0][1]) + Convert.ToDouble(txt_bill.Text);
                            string x1 = x.ToString();
                            _OPPOINTMENT._update_bill(Convert.ToInt32(txtid_paiton.Text)
                                , x1);

                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }

                    }

                    //********************************************

                    //في حالة المريض لم يقم باضافته من قبل 
                    else if (_APP_PASTOIN._SELECTE_ss(Convert.ToInt32(txtid_paiton.Text)).Rows.Count == 0)
                    {
                        if (txt_bullstuts.SelectedItem == "تم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            _APP_PASTOIN.APPPASOINr_insert("0", Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "لم يتم الدفع")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            _APP_PASTOIN.APPPASOINr_insert(txt_bill.Text, Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }
                        else if (txt_bullstuts.SelectedItem == "قيمة ناقصة")
                        {
                            _OPPOINTMENT._insert(Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(date), user1, IMAGE, "n");
                            _APP_PASTOIN.APPPASOINr_insert(txt_bill.Text, Convert.ToDateTime(date), user1, Convert.ToInt32(txtid_paiton.Text));
                            load();
                            MessageBox.Show("تمت الاضافة");
                        }

                        //***********
                    }

                }
                clean();
            }
            catch
            {
                MessageBox.Show("خطاء");
            }

            //****************************




        }
        private void button2_Click(object sender, EventArgs e)
        {

            if ( txt_bill.Text == "" || txtid_paiton.Text == "" || txtid_docter.Text == "")
            {
                MessageBox.Show("الرجاء ادخال جميع البيانات");
            }
            else if (MessageBox.Show("تأكيد التعديل", "هل تريد التعديل!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {
                if (pictureBox1.Image != null)
                {

                    MemoryStream MS = new MemoryStream();
                    pictureBox1.Image.Save(MS, pictureBox1.Image.RawFormat);
                    byte[] IMAGE = MS.ToArray();

                    _OPPOINTMENT._update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()), user1, IMAGE, "I");
                    load();
                    MessageBox.Show("تمت تعديل");
                }


                else
                {
                    byte[] IMAGE = new byte[4];
                    _OPPOINTMENT._update(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), Convert.ToInt32(txtid_paiton.Text), Convert.ToInt32(txtid_docter.SelectedValue), txtdate_opp.Text, txttime_opp.Text, txtnotes.Text, txt_stuts.Text, txt_bill.Text, txt_bullstuts.Text, txt_prescripiton.Text, Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()), user1, IMAGE, "b");
                    load();
                    MessageBox.Show("تمت تعديل");
                }

            }
        }

        private void txtid_paiton_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtid_docter.DataSource = _DOCTOR._SELECTE("");
            //txtid_docter.ValueMember = "ID";
            //txtid_docter.DisplayMember = "FULLNAME";

        }


        //لRefrech ال compobox
        public void kk()
        {
            try
            {

            }
            catch
            {

            }
        }
        void clean()
        {
            txtnotes.Text = "";
            txt_bill.Text = "";
            txt_prescripiton.Text = "";
        }
        private void OPPOINTMENT_Load(object sender, EventArgs e)
        {

            //this.dOCTORTableAdapter.Fill(this.dental_ClinicDataSet.DOCTOR);
            //this.lOG_DOCTORTableAdapter.Fill(this.dental_ClinicDataSet.LOG_DOCTOR);


            ////*******************
            //this.pATIENTTableAdapter.Fill(this.dental_ClinicDataSet.PATIENT);

            //this.log_PATIENTTableAdapter.Fill(this.dental_ClinicDataSet.log_PATIENT);

            //this.txtid_docter.Refresh();
            //this.txtbox1.Refresh();

            //******************
            txtid_docter.DataSource = _DOCTOR.selcet_docter_chose();
            txtid_docter.DisplayMember = "FULLNAME";
            txtid_docter.ValueMember = "ID";
            

            comboBox1.DataSource = _PATIENT.selcet_PATIENT_chose();
            comboBox1.DisplayMember = "FULLNAME";
            comboBox1.ValueMember = "ID";
            
            //**************************
            txt_stuts.SelectedIndex = 0; txt_bullstuts.SelectedIndex = 0;
            // ***********************************
            load();

        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _OPPOINTMENT.APPPASOIN_SELECTE(txtserach.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "الصور|*.jpg;*.png;*.bmp;*.jpeg";
            ofd.Multiselect = false;
            ofd.Title = "قم باختيار الصورة ";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //////////////////////////////////////



            //     byte img = pictureBox1.Image;
            //          img.Height = "768";
            //          img.width = "768";


            //  var img = document.getElementById("x");
            //x.height = "250";
            //x.width = "250";
            //      }

            /////////////////////////////////////////
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                getzoom(1);
            }

            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Width = pictureBox1.Width - 50;
                pictureBox1.Height = pictureBox1.Height - 50;
            }


        }



        private void getzoom(int zoomsize)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("يجب وضع صورة اولا");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int newwidght = pictureBox1.Image.Width / zoomsize;
                int newhidght = pictureBox1.Image.Height / zoomsize;

                Bitmap bmpnew = new Bitmap(newwidght, newhidght);
                Graphics gr = Graphics.FromImage(bmpnew);
                gr.DrawImage(bmp, 0, 0, newwidght, newhidght);
                pictureBox1.Image = bmpnew;
                panel1.AutoScrollMinSize = new Size(pictureBox1.Image.Width, pictureBox1.Image.Height);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void zoon()
        {
            txtbox1.Text = _OPPOINTMENT.show_name_paiton(Convert.ToInt32(txtid_paiton.Text)).Rows[0][0].ToString();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
                {

                    txtid_docter.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtbox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtdate_opp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txttime_opp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txt_stuts.SelectedItem = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    txt_bill.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txt_bullstuts.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    txt_prescripiton.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    txtnotes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString() ;
                    pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[12].Value));
                    button6.Enabled = true;
                    txtid_paiton.Text= dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    zoon();
                }

                else
                {
                    button6.Enabled = false;
                }
                
            }
            catch
            {


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                txtid_docter.DataSource = _DOCTOR.selcet_docter_chose();
                txtid_docter.DisplayMember = "FULLNAME";
                txtid_docter.ValueMember = "ID";


                comboBox1.DataSource = _PATIENT.selcet_PATIENT_chose();
                comboBox1.DisplayMember = "FULLNAME";
                comboBox1.ValueMember = "ID";
                txtid_docter.SelectedIndex = 0;


                comboBox1.SelectedIndex = 0;
                load();
            }
            catch 
            {
             }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2(this);
            m.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
             if (MessageBox.Show("تأكيد الحذف", "هل تريد الحذف!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) == DialogResult.Yes)
            {

                _OPPOINTMENT._delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                load();
                MessageBox.Show("تمت الحذف");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PL.paiton_select b = new PL.paiton_select(this);
            b.Show();
        }
    }
    //private void pictureBox1_DoubleClick(object sender, EventArgs e)
    //{
    //    int ss = 50;
        //int hh = 500;

        //if (dataGridView1.Rows.Count < ss )
        //{

        //    pictureBox1.Width = pictureBox1.Width + 500;
        //    pictureBox1.Height = pictureBox1.Height + 500;
        //}
        //if (dataGridView1.Rows.Count < ss)
        //{
        //    pictureBox1.Width = pictureBox1.Width - 50;
        //    pictureBox1.Height = pictureBox1.Height - 50;
        //}
        //if (dataGridView1.Rows.Count == 0)
        //{
        //    pictureBox1.Width = pictureBox1.Width - 500;
        //    pictureBox1.Height = pictureBox1.Height - 500;
        // }

  //  }     
           

        
   // }
}
