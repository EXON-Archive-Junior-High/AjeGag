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
            timer.Start();
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
                msg.Text = "맞았습니다!";
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
                        msg.Text = "맞았습니다!";
                        break;
                    }
                }
                result.Text = string.Empty;
                msg.Text = "틀렸습니다.";

            }
            else
            {
                result.Text = string.Empty;
                msg.Text = "틀렸습니다.";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        
        }

        private void GetAje()
        {
            Data data = new Data();

            data.Problem(ref key, ref value);


            problem.Text = key;

        }
    }
}
