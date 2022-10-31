
namespace Attendance_Management
{
    partial class Class_Schedule3
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
            this.cOURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSSCHEDULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sT_LOGINDataSet5 = new Attendance_Management.ST_LOGINDataSet5();
            this.cLASS_SCHEDULETableAdapter = new Attendance_Management.ST_LOGINDataSet5TableAdapters.CLASS_SCHEDULETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSEIDDataGridViewTextBoxColumn,
            this.cOURSENAMEDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.rOOMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLASSSCHEDULEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 329);
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
            this.cLASSSCHEDULEBindingSource.DataSource = this.sT_LOGINDataSet5;
            // 
            // sT_LOGINDataSet5
            // 
            this.sT_LOGINDataSet5.DataSetName = "ST_LOGINDataSet5";
            this.sT_LOGINDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLASS_SCHEDULETableAdapter
            // 
            this.cLASS_SCHEDULETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Schedule";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(569, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "GO BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Class_Schedule3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(707, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Class_Schedule3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Schedule3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ST_LOGINDataSet5 sT_LOGINDataSet5;
        private System.Windows.Forms.BindingSource cLASSSCHEDULEBindingSource;
        private ST_LOGINDataSet5TableAdapters.CLASS_SCHEDULETableAdapter cLASS_SCHEDULETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}