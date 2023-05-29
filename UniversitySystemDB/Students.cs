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
    public partial class Students : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\Tamrin\\winform\\UniversitySystemDB\\UniversitySystemDB\\SystemDB.mdf;Integrated Security=True");

        AddStudent adf = new AddStudent();
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

            LoadStudents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            try
            {
                string selectedStudent = studentList.SelectedItem.ToString();
                conn.Open();

                string deleteQuery = $"DELETE FROM Students WHERE FirstName = '{selectedStudent}'";
                SqlCommand command = new SqlCommand(deleteQuery, conn);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("رکورد با موفقیت حذف شد.");
                    studentList.Items.Remove(selectedStudent);
                    studentList.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("خطا در حذف رکورد.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ارتباط با پایگاه داده: " + ex.Message);
            }
            conn.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adf.Show();
        }

        private void Students_Activated(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                    conn.Open();
                    string selectQuery = "SELECT FirstName FROM Students";
                    SqlCommand command = new SqlCommand(selectQuery, conn);

                    SqlDataReader reader = command.ExecuteReader();

                    studentList.Items.Clear();

                    while (reader.Read())
                    {
                        string name = reader["FirstName"].ToString();
                        studentList.Items.Add(name);
                    }

                    reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ارتباط با پایگاه داده: " + ex.Message);
            }
            conn.Close();
        }

    }
}
