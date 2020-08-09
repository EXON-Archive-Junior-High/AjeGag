namespace Main
{
    partial class End
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restart = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.score = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // restart
            // 
            this.restart.BorderRadius = 15;
            this.restart.CheckedState.Parent = this.restart;
            this.restart.CustomImages.Parent = this.restart;
            this.restart.FillColor = System.Drawing.Color.DimGray;
            this.restart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.restart.ForeColor = System.Drawing.Color.White;
            this.restart.HoverState.Parent = this.restart;
            this.restart.Location = new System.Drawing.Point(28, 203);
            this.restart.Name = "restart";
            this.restart.ShadowDecoration.Parent = this.restart;
            this.restart.Size = new System.Drawing.Size(180, 45);
            this.restart.TabIndex = 0;
            this.restart.Text = "Restart";
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(68, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(82, 37);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Score";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(15, 46);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(60, 21);
            this.score.TabIndex = 2;
            this.score.Text = "Score : ";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 266);
            this.Controls.Add(this.score);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "End";
            this.Text = "End";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.End_FormClosing);
            this.Load += new System.EventHandler(this.End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button restart;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel score;
    }
}