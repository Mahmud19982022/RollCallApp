using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace Attendance_Management
{
    public partial class Student_Details : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Student_Details()
        {
            InitializeComponent();
            ResetControl();
          
           
        }


       

       

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
            button4.ForeColor = Color.Blue;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Portal stu = new Student_Portal();
            stu.Show();
        }



       

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into students values (@studentid,@name,@age,@presentaddress,@parmanentaddress,@department,@religion,@phoneno,@bloodgroup)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@studentid", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@presentaddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@parmanentaddress", textBox5.Text);
            cmd.Parameters.AddWithValue("@department", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@religion", textBox7.Text);
            cmd.Parameters.AddWithValue("@phoneno", textBox8.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", textBox9.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Student Information Submited Successfully ! ");
                ResetControl();
              
              
            }
            else
            {
                MessageBox.Show("Student Information not Submited  ! ");
            }

            con.Close();
        }

        private void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex=-1;
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {/*
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            */
        }

       

       
       
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.WhiteSmoke;
            button5.ForeColor = Color.Blue;
        }

       

      
    }
}
