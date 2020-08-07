namespace Main
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.result = new Guna.UI2.WinForms.Guna2TextBox();
            this.problem = new Guna.UI.WinForms.GunaLabel();
            this.submission = new Guna.UI2.WinForms.Guna2Button();
            this.msg = new Guna.UI.WinForms.GunaLabel();
            this.timer = new Guna.UI.WinForms.GunaLabel();
            this.score = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BorderRadius = 10;
            this.result.BorderThickness = 0;
            this.result.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.result.DefaultText = "";
            this.result.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.result.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.result.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.result.DisabledState.Parent = this.result;
            this.result.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.result.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.result.FocusedState.Parent = this.result;
            this.result.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.result.HoverState.Parent = this.result;
            this.result.Location = new System.Drawing.Point(215, 182);
            this.result.Name = "result";
            this.result.PasswordChar = '\0';
            this.result.PlaceholderText = "";
            this.result.SelectedText = "";
            this.result.ShadowDecoration.Parent = this.result;
            this.result.Size = new System.Drawing.Size(233, 33);
            this.result.TabIndex = 0;
            this.result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.result_KeyDown);
            // 
            // problem
            // 
            this.problem.AutoSize = true;
            this.problem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problem.Location = new System.Drawing.Point(210, 154);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(88, 25);
            this.problem.TabIndex = 1;
            this.problem.Text = "문제이름";
            this.problem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.problem.UseMnemonic = false;
            // 
            // submission
            // 
            this.submission.BorderRadius = 10;
            this.submission.CheckedState.Parent = this.submission;
            this.submission.CustomImages.Parent = this.submission;
            this.submission.FillColor = System.Drawing.Color.DimGray;
            this.submission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submission.ForeColor = System.Drawing.Color.White;
            this.submission.HoverState.Parent = this.submission;
            this.submission.Location = new System.Drawing.Point(242, 221);
            this.submission.Name = "submission";
            this.submission.ShadowDecoration.Parent = this.submission;
            this.submission.Size = new System.Drawing.Size(180, 45);
            this.submission.TabIndex = 2;
            this.submission.Text = "제출";
            this.submission.Click += new System.EventHandler(this.submission_Click);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(210, 286);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 20);
            this.msg.TabIndex = 3;
            this.msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.msg.UseMnemonic = false;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(211, 316);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(0, 20);
            this.timer.TabIndex = 4;
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer.UseMnemonic = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(261, 123);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(17, 20);
            this.score.TabIndex = 5;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score.UseMnemonic = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(211, 122);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 20);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Score: ";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.UseMnemonic = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.submission);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox result;
        private Guna.UI.WinForms.GunaLabel problem;
        private Guna.UI2.WinForms.Guna2Button submission;
        private Guna.UI.WinForms.GunaLabel msg;
        private Guna.UI.WinForms.GunaLabel timer;
        private Guna.UI.WinForms.GunaLabel score;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}

