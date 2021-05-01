using System;
using System.Windows.Forms;

namespace BeatBall
{
    class  Guide : Form
    {
        private Label lblGuide1;
        private Label lblGuide2;
        private Label lblGuide3;
        private Label lblBack;

        public Guide()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide));
            this.lblGuide1 = new System.Windows.Forms.Label();
            this.lblGuide2 = new System.Windows.Forms.Label();
            this.lblGuide3 = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuide1
            // 
            this.lblGuide1.AutoSize = true;
            this.lblGuide1.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide1.ForeColor = System.Drawing.Color.Red;
            this.lblGuide1.Text = " In ordet to PLAY just click\r\n";
            this.lblGuide1.Location = new System.Drawing.Point((this.ClientRectangle.Width - this.lblGuide1.PreferredSize.Width) / 2, 114);
            // 
            // lblGuide2
            // 
            this.lblGuide2.AutoSize = true;
            this.lblGuide2.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide2.ForeColor = System.Drawing.Color.White;
            this.lblGuide2.Text = 
                "                                                             Instruction of the game:\n" + 
                "                                    Press the keys right and left, break all bricks and records.\n" +
                "                                    Becareful !! you must hit the ball and prevent it from falling.\n\n" + 
                "                                                Do you need a break ? just press Space\n" +
                "                                                   Do you want to exit ? press Esc\n\n" +
                "          In order to control the audio, to see high score or to read about the game enter to main screen\n\r";
                

            this.lblGuide2.Location = new System.Drawing.Point((this.ClientRectangle.Width - this.lblGuide2.PreferredSize.Width) / 2, 180);
            // 
            // lblGuide3
            // 
            this.lblGuide3.AutoSize = true;
            this.lblGuide3.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblGuide3.ForeColor = System.Drawing.Color.Red;
            this.lblGuide3.Text = " Enjoy and Good luck\r\n  by S.W.A.T team ©\r\n";
            this.lblGuide3.Location = new System.Drawing.Point((this.ClientRectangle.Width - this.lblGuide3.PreferredSize.Width) / 2, 700);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Name = "lblBack";
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "Back";
            this.lblBack.Location = new System.Drawing.Point(30, this.ClientRectangle.Height - this.lblBack.PreferredSize.Height-20);
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // Guide
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblGuide3);
            this.Controls.Add(this.lblGuide2);
            this.Controls.Add(this.lblGuide1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guide";
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
            this.Close();
            f.ShowDialog();
        }


    }
}
