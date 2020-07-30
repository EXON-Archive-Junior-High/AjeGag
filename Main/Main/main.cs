using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        string key, value = string.Empty;

        private void main_Load(object sender, EventArgs e)
        {
            Data data = new Data();

            data.Problem(ref key, ref value);

            problem.Text = key;
        }

        private void submission_Click(object sender, EventArgs e)
        {
            if (result.Text == value)
            {
                this.Close();
            }
        }
    }
}
