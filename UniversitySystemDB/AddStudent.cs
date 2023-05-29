using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemDB
{
    public partial class AddStudent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Tamrin\\winform\\UniversitySystemDB\\UniversitySystemDB\\SystemDB.mdf;Integrated Security=True");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string studentID = textBox3.Text;
            string phoneNumber = textBox4.Text; 

                try
                {
                    conn.Open();

                    string insertQuery = $"INSERT INTO Students (FirstName,LastName,StudentID,PhoneNumber) VALUES ('{firstName}', '{lastName}', '{studentID}', '{phoneNumber}')";
                    SqlCommand command = new SqlCommand(insertQuery, conn);
                    int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    {
                    MessageBox.Show("رکورد با موفقیت اضافه شد.");
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                }
                    else
                    {
                    MessageBox.Show("خطا در افزودن رکورد.");
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show("خطا در ارتباط با پایگاه داده: " + ex.Message);
                }
            conn.Close();
            }
        }
    }

