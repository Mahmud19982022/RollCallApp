
namespace Attendance_Management
{
    partial class Class_Schedule4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSSCHEDULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sT_LOGINDataSet9 = new Attendance_Management.ST_LOGINDataSet9();
            this.label1 = new System.Windows.Forms.Label();
            this.cLASS_SCHEDULETableAdapter = new Attendance_Management.ST_LOGINDataSet9TableAdapters.CLASS_SCHEDULETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSEIDDataGridViewTextBoxColumn,
            this.cOURSENAMEDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.rOOMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLASSSCHEDULEBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(684, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cOURSEIDDataGridViewTextBoxColumn
            // 
            this.cOURSEIDDataGridViewTextBoxColumn.DataPropertyName = "COURSEID";
            this.cOURSEIDDataGridViewTextBoxColumn.HeaderText = "COURSEID";
            this.cOURSEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOURSEIDDataGridViewTextBoxColumn.Name = "cOURSEIDDataGridViewTextBoxColumn";
            this.cOURSEIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // cOURSENAMEDataGridViewTextBoxColumn
            // 
            this.cOURSENAMEDataGridViewTextBoxColumn.DataPropertyName = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.HeaderText = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOURSENAMEDataGridViewTextBoxColumn.Name = "cOURSENAMEDataGridViewTextBoxColumn";
            this.cOURSENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sECTIONDataGridViewTextBoxColumn
            // 
            this.sECTIONDataGridViewTextBoxColumn.DataPropertyName = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.HeaderText = "SECTION";
            this.sECTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sECTIONDataGridViewTextBoxColumn.Name = "sECTIONDataGridViewTextBoxColumn";
            this.sECTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            this.tIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rOOMNODataGridViewTextBoxColumn
            // 
            this.rOOMNODataGridViewTextBoxColumn.DataPropertyName = "ROOMNO";
            this.rOOMNODataGridViewTextBoxColumn.HeaderText = "ROOMNO";
            this.rOOMNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rOOMNODataGridViewTextBoxColumn.Name = "rOOMNODataGridViewTextBoxColumn";
            this.rOOMNODataGridViewTextBoxColumn.Width = 125;
            // 
            // cLASSSCHEDULEBindingSource
            // 
            this.cLASSSCHEDULEBindingSource.DataMember = "CLASS_SCHEDULE";
            this.cLASSSCHEDULEBindingSource.DataSource = this.sT_LOGINDataSet9;
            // 
            // sT_LOGINDataSet9
            // 
            this.sT_LOGINDataSet9.DataSetName = "ST_LOGINDataSet9";
            this.sT_LOGINDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CLASS SCHEDULE";
            // 
            // cLASS_SCHEDULETableAdapter
            // 
            this.cLASS_SCHEDULETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Class_Schedule4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(747, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Class_Schedule4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Schedule4";
            this.Load += new System.EventHandler(this.Class_Schedule4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private ST_LOGINDataSet9 sT_LOGINDataSet9;
        private System.Windows.Forms.BindingSource cLASSSCHEDULEBindingSource;
        private ST_LOGINDataSet9TableAdapters.CLASS_SCHEDULETableAdapter cLASS_SCHEDULETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}