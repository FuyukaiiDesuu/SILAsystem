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
    public partial class AddStudent : Form
    {
        public EnrollmentMain reference { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reference.Show();
            this.Close();
        }
    }
}
