using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_2_1214079
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void TimeOption_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutputGroupBox_Enter(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
