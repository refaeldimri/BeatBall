using System;
using System.Windows.Forms;

namespace BeatBall
{
    public partial class MainForm : Form
    {
        private Label lblPlay;
        private Label lblGuide;
        private Label lblAbout;
        private Label lblHighScore;
        private Label lblSetting;
        private Label lblExit;

        // private void InitializeComponent()
        public MainForm()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblPlay = new System.Windows.Forms.Label();
            this.lblGuide = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            //((System.ComponentModel.ISupportInitialize)(this.picSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlay.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Text = "Play";
            this.lblPlay.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.lblPlay.PreferredSize.Width)/2,
                                                                 2*Screen.PrimaryScreen.Bounds.Height / 8 - this.lblPlay.PreferredSize.Height);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.lblPlay_MouseLeave);
            this.lblPlay.MouseHover += new System.EventHandler(this.lblPlay_MouseHover);
            // 
            // lblGuide
            // 
            this.lblGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuide.AutoSize = true;
            this.lblGuide.BackColor = System.Drawing.Color.Transparent;
            this.lblGuide.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuide.ForeColor = System.Drawing.Color.White;
            this.lblGuide.Text = "Guide";
            this.lblGuide.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.lblGuide.PreferredSize.Width)/2,
                                                                3 * Screen.PrimaryScreen.Bounds.Height / 8 - this.lblGuide.PreferredSize.Height);
            this.lblGuide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuide.Click += new System.EventHandler(this.lblGuide_Click);
            this.lblGuide.MouseLeave += new System.EventHandler(this.lblGuide_MouseLeave);
            this.lblGuide.MouseHover += new System.EventHandler(this.lblGuide_MouseHover);
            // 
            // lblAbout
            // 
            this.lblAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.Transparent;
            this.lblAbout.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Text = "About";
            this.lblAbout.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.lblAbout.PreferredSize.Width)/2,
                                                                4 * Screen.PrimaryScreen.Bounds.Height / 8 - this.lblAbout.PreferredSize.Height);
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            this.lblAbout.MouseLeave += new System.EventHandler(this.lblAbout_MouseLeave);
            this.lblAbout.MouseHover += new System.EventHandler(this.lblAbout_MouseHover);
            // 
            // lblHighScore
            // 
            this.lblHighScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Text = "High Score";
            this.lblHighScore.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.lblHighScore.PreferredSize.Width)/2,
                                                                6 * Screen.PrimaryScreen.Bounds.Height / 8 - this.lblHighScore.PreferredSize.Height);
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore.Click += new System.EventHandler(this.lblHighScore_Click);
            this.lblHighScore.MouseLeave += new System.EventHandler(this.lblHighScore_MouseLeave);
            this.lblHighScore.MouseHover += new System.EventHandler(this.lblHighScore_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Text = "Exit";
            this.lblExit.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - this.lblExit.PreferredSize.Width - 70,
                                                                 Screen.PrimaryScreen.Bounds.Height - this.lblExit.PreferredSize.Height - 90);
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSetting.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.ForeColor = System.Drawing.Color.White;
            this.lblSetting.Text = "Setting";
            this.lblSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lblSetting.Image = BeatBall.Properties.Resources.setting;
            this.lblSetting.Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - this.lblSetting.PreferredSize.Width) / 2,
                                              5 * Screen.PrimaryScreen.Bounds.Height / 8 - this.lblHighScore.PreferredSize.Height);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.TabStop = false;
            this.lblSetting.Click += new System.EventHandler(this.lblSetting_Click);
            this.lblSetting.MouseLeave += new System.EventHandler(this.lblSetting_MouseLeave);
            this.lblSetting.MouseHover += new System.EventHandler(this.lblSetting_MouseHover);
            // 
            // MainForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblGuide);
            this.Controls.Add(this.lblPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "BeatBall";
          //  ((System.ComponentModel.ISupportInitialize)(this.lblSetting)).EndInit();
            this.PerformLayout();
            this.ResumeLayout();

            // this part avoid flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.UserPaint |
                       ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        public void LoadForm(Form newForm)
        {
            newForm.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void lblPlay_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                Cursor.Current = Cursors.Hand;
                ((Label)sender).ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lblPlay_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblPlay.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblGuide_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblGuide.ForeColor = System.Drawing.Color.Red;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void lblGuide_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblGuide.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblAbout_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblAbout.ForeColor = System.Drawing.Color.Red;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void lblAbout_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblAbout.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblSetting_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblSetting.ForeColor = System.Drawing.Color.Red;
                Cursor.Current = Cursors.Default;
            }
        }
        private void lblSetting_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblSetting.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblHighScore_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblHighScore.ForeColor = System.Drawing.Color.Red;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void lblHighScore_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblHighScore.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblExit.ForeColor = System.Drawing.Color.Red;
                Cursor.Current = Cursors.Hand;
            }
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                this.lblExit.ForeColor = System.Drawing.Color.White;
                Cursor.Current = Cursors.Default;
            }
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            Player.Score = 0;
            Player.Strikes = 3;
            LevelForm f = new LevelForm();
            LoadForm(f);
        }

        private void lblGuide_Click(object sender, EventArgs e)
        {
            Guide f = new Guide();
            LoadForm(f);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            About f = new About();
            LoadForm(f);
        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            Setting f = new Setting();
            LoadForm(f);
        }

        private void lblHighScore_Click(object sender, EventArgs e)
        {
           
            HighScore f = new HighScore();
            LoadForm(f);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }




    }
}
