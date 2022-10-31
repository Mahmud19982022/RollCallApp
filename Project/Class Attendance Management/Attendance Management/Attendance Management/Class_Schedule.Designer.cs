
namespace Attendance_Management
{
    partial class Class_Schedule
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cOURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOOMNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSSCHEDULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sT_LOGINDataSet10 = new Attendance_Management.ST_LOGINDataSet10();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cLASS_SCHEDULETableAdapter = new Attendance_Management.ST_LOGINDataSet10TableAdapters.CLASS_SCHEDULETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1101",
            "1102",
            "1103",
            "2101",
            "2102",
            "2103",
            "3101",
            "3102",
            "3103",
            "4101",
            "4102",
            "4103",
            "DS0101",
            "DS0102",
            "DN0202"});
            this.comboBox3.Location = new System.Drawing.Point(209, 293);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 28);
            this.comboBox3.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "SECTION";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SUN8:00AM-SUN10:00AM",
            "SUN11:00AM-SUN2:00PM",
            "MON11:00AM-MON2:00PM",
            "MON2:00PM-MON5:00PM",
            "TUE8:00AM-TUE10:00AM",
            "TUE11:00AM-TUE2:00PM",
            "WED11:00AM-WED2:00PM",
            "WED2:00PM-WED5:00PM",
            "THU11:00AM-THU2:00PM",
            "THU2:00PM-THU5:00PM"});
            this.comboBox2.Location = new System.Drawing.Point(209, 243);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox1.Location = new System.Drawing.Point(209, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(209, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 27);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(209, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 27);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "ROOMNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "TIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "COURSENAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "COURSEID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 36);
            this.label6.TabIndex = 22;
            this.label6.Text = " Class Schedule";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 61);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(1, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSEIDDataGridViewTextBoxColumn,
            this.cOURSENAMEDataGridViewTextBoxColumn,
            this.sECTIONDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.rOOMNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLASSSCHEDULEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(501, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 220);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            this.cLASSSCHEDULEBindingSource.DataSource = this.sT_LOGINDataSet10;
            // 
            // sT_LOGINDataSet10
            // 
            this.sT_LOGINDataSet10.DataSetName = "ST_LOGINDataSet10";
            this.sT_LOGINDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(563, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 61);
            this.button3.TabIndex = 26;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(385, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 61);
            this.button4.TabIndex = 27;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(754, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 61);
            this.button5.TabIndex = 28;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // cLASS_SCHEDULETableAdapter
            // 
            this.cLASS_SCHEDULETableAdapter.ClearBeforeFill = true;
            // 
            // Class_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1216, 512);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Class_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class_Schedule";
            this.Load += new System.EventHandler(this.Class_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSSCHEDULEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sT_LOGINDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private ST_LOGINDataSet10 sT_LOGINDataSet10;
        private System.Windows.Forms.BindingSource cLASSSCHEDULEBindingSource;
        private ST_LOGINDataSet10TableAdapters.CLASS_SCHEDULETableAdapter cLASS_SCHEDULETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOOMNODataGridViewTextBoxColumn;
    }
}