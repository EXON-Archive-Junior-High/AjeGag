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
    public partial class End : Form
    {
        string Score = string.Empty;
        public End(string Score)
        {
            InitializeComponent();
            this.Score = Score;
        }

        private void End_Load(object sender, EventArgs e)
        {
            score.Text += Score;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void End_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
