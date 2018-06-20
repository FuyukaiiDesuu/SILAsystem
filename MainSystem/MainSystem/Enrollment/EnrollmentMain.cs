using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainSystem
{
    public partial class EnrollmentMain : Form
    {
        public EnrollmentMain()
        {
            InitializeComponent();
        }
        public AddStudent addstudentform;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addstudentform = new AddStudent();
            addstudentform.Show();
            this.Hide();
            addstudentform.reference = this;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
