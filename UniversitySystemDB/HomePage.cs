using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystemDB
{
    public partial class HomePage : Form
    {
        Professors pf = new Professors();
        Students sf = new Students();
        public HomePage()
        {
            InitializeComponent();  
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            sf.Show();
        }

        private void btn_prfsr_Click(object sender, EventArgs e)
        {
            pf.Show();
        }
    }
}
