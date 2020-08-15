using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Main
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        string key, value = string.Empty;
        Stopwatch sw = new Stopwatch();
        Stopwatch allTime = new Stopwatch();
        int Score = 0;

        private void main_Load(object sender, EventArgs e)
        {
            GetAje();
            allTime.Start();
            sw.Start();
        }

        private void main_Load()
        {
            GetAje();
            allTime.Start();
            sw.Start();
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

        // 답인지 아닌지 판별하는 함수
        private void Submit()
        {

            if (result.Text == value) // 답이 같지 않으면?
            {
                GetAje();
                Correct();
            }
            else if (value.Contains("|")) // 답의 경우수가 여러개이면?
            {
                int isTrue = 0;
                string[] v = value.Split('|');
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] == result.Text)
                    {
                        GetAje();
                        Correct();
                        isTrue = 1;
                        break;
                    }
                }
                if (isTrue == 0)
                {
                    Wrong();
                }


            }
            else
            {
                Wrong();
            }
        }

        private void Correct()
        {
            result.Text = string.Empty;
            msg.Text = "맞았습니다!";
            timer.Text = $"{sw.Elapsed.TotalSeconds.ToString()}s";
            score.Text = (Score + Point.SetPoint(sw.Elapsed.TotalSeconds)).ToString();
            Score = Convert.ToInt32(score.Text);
            sw.Restart();
            CheckTime();
        }

        private void Wrong()
        {
            result.Text = string.Empty;
            msg.Text = "틀렸습니다.";
            CheckTime();
        }

        private void CheckTime()
        {
            if (allTime.Elapsed.TotalSeconds > 60)
            {
                End(Score.ToString());
            }
        }

        private void End(string a)
        {
            sw = new Stopwatch();
            allTime = new Stopwatch();
            Reset();
            End end = new End(a);
            end.ShowDialog();
        }


        private void GetAje()
        {
            Data data = new Data();

            data.Problem(ref key, ref value);
            if (value.Contains("|")) // 답의 경우수가 여러개이면?
            {
                string v = value.Split('|')[0];
                key += $" [{v.Length}글자]";
            }
            else
            {
                string v = value;
                key += $" [{v.Length}글자]";
            }
                problem.Text = key;

        }

        private void skip_Click(object sender, EventArgs e)
        {
            score.Text = (Convert.ToInt32(score.Text) - 5).ToString();
            GetAje();
            sw = new Stopwatch();
            sw.Start();
        }

        private void Reset()
        {
            score.Text = "0";
            problem.Text = string.Empty;
            timer.Text = string.Empty;
            msg.Text = string.Empty;

            Score = 0;
            main_Load();
        }
    }
}
