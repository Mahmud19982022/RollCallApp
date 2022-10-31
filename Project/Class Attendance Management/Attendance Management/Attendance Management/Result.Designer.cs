
namespace Attendance_Management
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultUploadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sT_LOGINDataSet3 = new Attendance_Management.ST_LOGINDataSet3();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sT_LOGINDataSet1 = new Attendance_Management.ST_LOGINDataSet1();
            this.sT_LOGINDataSet = new Attendance_Management.ST_LOGINDataSet();
            this.sTLOGINDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTableAdapter = new Attendance_Management.ST_LOGINDataSet1TableAdapters.resultTableAdapter();
            this.result_UploadTableAdapter = new Attendance_Management.ST_LOGINDataSet3TableAdapters.Result_UploadTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultUploadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTLOGINDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE_RESULT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSENAMEDataGridViewTextBoxColumn,
            this.mARKSDataGridViewTextBoxColumn,
            this.gRADEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultUploadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 312);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cOURSENAMEDataGridViewTextBoxColumn
            // 
            this.cOURSENAMEDataGridViewTextBoxColumn.DataPropertyName = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.HeaderText = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cOURSENAMEDataGridViewTextBoxColumn.Name = "cOURSENAMEDataGridViewTextBoxColumn";
            this.cOURSENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // mARKSDataGridViewTextBoxColumn
            // 
            this.mARKSDataGridViewTextBoxColumn.DataPropertyName = "MARKS";
            this.mARKSDataGridViewTextBoxColumn.HeaderText = "MARKS";
            this.mARKSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mARKSDataGridViewTextBoxColumn.Name = "mARKSDataGridViewTextBoxColumn";
            this.mARKSDataGridViewTextBoxColumn.Width = 125;
            // 
            // gRADEDataGridViewTextBoxColumn
            // 
            this.gRADEDataGridViewTextBoxColumn.DataPropertyName = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.HeaderText = "GRADE";
            this.gRADEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gRADEDataGridViewTextBoxColumn.Name = "gRADEDataGridViewTextBoxColumn";
            this.gRADEDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultUploadBindingSource
            // 
            this.resultUploadBindingSource.DataMember = "Result_Upload";
            this.resultUploadBindingSource.DataSource = this.sT_LOGINDataSet3;
            // 
            // sT_LOGINDataSet3
            // 
            this.sT_LOGINDataSet3.DataSetName = "ST_LOGINDataSet3";
            this.sT_LOGINDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "result";
            this.resultBindingSource.DataSource = this.sT_LOGINDataSet1;
            // 
            // sT_LOGINDataSet1
            // 
            this.sT_LOGINDataSet1.DataSetName = "ST_LOGINDataSet1";
            this.sT_LOGINDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sT_LOGINDataSet
            // 
            this.sT_LOGINDataSet.DataSetName = "ST_LOGINDataSet";
            this.sT_LOGINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTLOGINDataSetBindingSource
            // 
            this.sTLOGINDataSetBindingSource.DataSource = this.sT_LOGINDataSet;
            this.sTLOGINDataSetBindingSource.Position = 0;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // result_UploadTableAdapter
            // 
            this.result_UploadTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(507, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultUploadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTLOGINDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ST_LOGINDataSet sT_LOGINDataSet;
        private System.Windows.Forms.BindingSource sTLOGINDataSetBindingSource;
        private ST_LOGINDataSet1 sT_LOGINDataSet1;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private ST_LOGINDataSet1TableAdapters.resultTableAdapter resultTableAdapter;
        private ST_LOGINDataSet3 sT_LOGINDataSet3;
        private System.Windows.Forms.BindingSource resultUploadBindingSource;
        private ST_LOGINDataSet3TableAdapters.Result_UploadTableAdapter result_UploadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}