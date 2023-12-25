namespace Dental_Clinic_Doctor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dental_ClinicDataSet2 = new Dental_Clinic_Doctor.Dental_ClinicDataSet2();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Dental_Clinic_Doctor.Dental_ClinicDataSet2TableAdapters.DataTable1TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOFAPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEOFAPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAME1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_ClinicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fULLNAMEDataGridViewTextBoxColumn,
            this.dATEOFAPPDataGridViewTextBoxColumn,
            this.tIMEOFAPPDataGridViewTextBoxColumn,
            this.bILSDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.fULLNAME1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // dental_ClinicDataSet2
            // 
            this.dental_ClinicDataSet2.DataSetName = "Dental_ClinicDataSet2";
            this.dental_ClinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dental_ClinicDataSet2;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fULLNAMEDataGridViewTextBoxColumn
            // 
            this.fULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "FULLNAME";
            this.fULLNAMEDataGridViewTextBoxColumn.HeaderText = "FULLNAME";
            this.fULLNAMEDataGridViewTextBoxColumn.Name = "fULLNAMEDataGridViewTextBoxColumn";
            // 
            // dATEOFAPPDataGridViewTextBoxColumn
            // 
            this.dATEOFAPPDataGridViewTextBoxColumn.DataPropertyName = "DATE_OF_APP";
            this.dATEOFAPPDataGridViewTextBoxColumn.HeaderText = "DATE_OF_APP";
            this.dATEOFAPPDataGridViewTextBoxColumn.Name = "dATEOFAPPDataGridViewTextBoxColumn";
            // 
            // tIMEOFAPPDataGridViewTextBoxColumn
            // 
            this.tIMEOFAPPDataGridViewTextBoxColumn.DataPropertyName = "TIME_OF_APP";
            this.tIMEOFAPPDataGridViewTextBoxColumn.HeaderText = "TIME_OF_APP";
            this.tIMEOFAPPDataGridViewTextBoxColumn.Name = "tIMEOFAPPDataGridViewTextBoxColumn";
            // 
            // bILSDataGridViewTextBoxColumn
            // 
            this.bILSDataGridViewTextBoxColumn.DataPropertyName = "BILS";
            this.bILSDataGridViewTextBoxColumn.HeaderText = "BILS";
            this.bILSDataGridViewTextBoxColumn.Name = "bILSDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // fULLNAME1DataGridViewTextBoxColumn
            // 
            this.fULLNAME1DataGridViewTextBoxColumn.DataPropertyName = "FULLNAME1";
            this.fULLNAME1DataGridViewTextBoxColumn.HeaderText = "FULLNAME1";
            this.fULLNAME1DataGridViewTextBoxColumn.Name = "fULLNAME1DataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 427);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dental_ClinicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private Dental_ClinicDataSet2 dental_ClinicDataSet2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Dental_ClinicDataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOFAPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEOFAPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAME1DataGridViewTextBoxColumn;
    }
}

