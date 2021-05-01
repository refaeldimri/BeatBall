using System;
using System.Windows.Forms;

namespace BeatBall
{
    class About : Form
    {
        private Label lblAbout;
        private Label lblBack;

      // private void InitializeComponent()
         public About()
        {

            //full screen
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lblBack = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(30, this.ClientRectangle.Height - this.lblBack.PreferredSize.Height - 20);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(114, 46);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAbout.ForeColor = System.Drawing.Color.Red;
            this.lblAbout.Location = new System.Drawing.Point(357, 237);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(967, 114);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "BeatBall by S.W.A.T – Omer Yehuda and Refael Dimri\r\nCreated as part of a C# proje" +
                                 "ct in “Kinerret academy collage”.\r\nThis project is accompanied by Dr. Dan Aharon" +
                                 "i.\r\n";
            // 
            // About
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

            // this part avoid flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.UserPaint |
                       ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        }
        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
                this.lblBack.ForeColor = System.Drawing.Color.Red;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
                this.lblBack.ForeColor = System.Drawing.Color.White;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            this.Hide();
            f.ShowDialog();
        }
    }
}
