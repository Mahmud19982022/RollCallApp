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
    public partial class Loginform : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Loginform()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please first fill up the  username");
            }
            else
            {
                errorProvider1.Clear();//not show errorprovider for 2nd time
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //admin username and pass
            if (textBox1.Text == "ADMIN" && textBox2.Text == "1234" && radioButton1.Checked == true)
            {
                this.Hide();
                AdminHome ah = new AdminHome();
                ah.Show();

            }



            else if (textBox1.Text != "" && textBox2.Text != "" && radioButton2.Checked == true)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from st_login1 where username=@user and password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                con.Open();



                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    Student_Portal stu = new Student_Portal();

                    stu.Show();


                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




                con.Close();
            }



            else if (textBox1.Text != "" && textBox2.Text != "" && radioButton3.Checked == true)
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from TR_LOGIN where username=@user and password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                con.Open();



                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Teacher_Portal newForm = new Teacher_Portal();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                con.Close();
            }






            else
            {
                MessageBox.Show("Please fill the form", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }

        }

       



        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.WhiteSmoke;
            button1.ForeColor = Color.Blue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (!Authenticate())
            {
                MessageBox.Show("Do Not Keep Any TextBox Blank!!!");
                return;
            }
            SqlConnection con = new SqlConnection(cs);

            string query = "INSERT INTO st_login1 values (@username ,@password )";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = textBox1.Text;
            cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar);
            cmd.Parameters["@password"].Value = textBox2.Text;


            cmd.ExecuteNonQuery();

            if (textBox1.Text != "" && textBox2.Text != "" && radioButton2.Checked == true)

            {
                MessageBox.Show("Register Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show("Register Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();



            bool Authenticate()
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                        string.IsNullOrWhiteSpace(textBox2.Text)
                        )
                    return false;
                else
                    return true;
            }
        }

       
        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
            button2.ForeColor = Color.Blue;
        }
    }
}
    

   


    