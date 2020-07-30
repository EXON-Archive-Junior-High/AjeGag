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
            GetAje();
        }

        private void submission_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }

        private void Submit()
        {

            if (result.Text == value)
            {
                GetAje();
                result.Text = string.Empty;
            }
            else if (value.Contains("|"))
            {
                string[] v = value.Split('|');
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] == result.Text)
                    {
                        GetAje();
                        result.Text = string.Empty;
                    }
                }

            }
        }

        private void GetAje()
        {
            Data data = new Data();

            data.Problem(ref key, ref value);


            problem.Text = key;

        }
    }
}
