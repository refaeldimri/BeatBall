using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace BeatBall
{
    class HighScore : Form
    {
        // File's name that created for save the score and show them in the table //
        private string fileName = "HighScore.txt";

        // field for store and sort the records list //
        private SortedDictionary<int, string> dictHighScore = new SortedDictionary<int, string>();

        // count the names of the players //
        private int counter = 0;

        // label for click and return to main screen //
        private Label lblBack;

        // label for click and send Email //
        private LinkLabel lblSendmail;

        // Field for open form that ask from user to insert name & Email //
        private InputForm inputForm;

        // Constructor //
        public HighScore()
        {
            try
            {
                this.SetValuesInFile();
                this.SetDictonery();

                if (Player.Score != 0)
                {
                    inputForm = new InputForm("Enter your name");
                    inputForm.ShowDialog();
                    for (int index = 0; index < 10; index++)
                    {
                        if ((int)dictHighScore.Keys.ElementAt<int>(index) < Player.Score)
                        {
                            dictHighScore.Remove((int)dictHighScore.Keys.ElementAt<int>(0));
                            try
                            {
                                dictHighScore.Add(Player.Score, Player.Name);
                            }
                            catch
                            {
                                try
                                {
                                    dictHighScore.Add(Player.Score, Player.Name + "");
                                }
                                catch
                                {
                                    int temp = 0;
                                    do
                                    {

                                    } while (dictHighScore.Keys.Contains<int>(Player.Score + ++temp));
                                    dictHighScore.Add(Player.Score + temp, Player.Name + "");
                                }
                            }
                            Player.Score = 0;
                            this.SetValuesInFile();
                            break;
                        }
                    }
                }
                counter = 0;
                foreach (int score in dictHighScore.Keys.Reverse<int>())
                {
                    string s;
                    if (score > 1)
                    {
                        dictHighScore.TryGetValue(score, out s);
                        this.Controls.Add(new Label()
                        {
                            Text = (1 + counter) + ") " + s + "............." + score.ToString(),
                            Location = new System.Drawing.Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2, 50 + (Screen.PrimaryScreen.Bounds.Width / 28) * counter++),
                            ForeColor = Color.Firebrick,
                            Font = new System.Drawing.Font("Ariel", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                            AutoSize = true
                        });
                    }
                    else
                    {
                        break;
                    }
                    if (counter > 9) break;
                }
            }
            catch
            {
                this.Close();
                this.Hide();
                Form f = new MainForm();
                f.ShowDialog();
            }
            #region 


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.lblBack = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Text = "Back";
            this.lblBack.TabIndex = 0;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            this.lblBack.Location = new System.Drawing.Point(20, Screen.PrimaryScreen.Bounds.Height - lblBack.Height * 3);

            // 
            // HighScore
            // 
            this.BackColor = Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 540);
            this.Controls.Add(this.lblBack);
            this.Name = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

            //full screen
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.lblSendmail = new LinkLabel()
            {
                Text = "send table in email to friend",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                AutoSize = true
            };

            this.lblSendmail.Click += LblSendmail_Click;
            this.lblSendmail.Location = new Point((this.ClientSize.Width  - this.lblSendmail.PreferredWidth)/ 2, this.ClientRectangle.Height - this.lblSendmail.Height - 30);
            this.Controls.Add(lblSendmail);

            // this part avoid flicker
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.UserPaint |
                       ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            #endregion
        }
        private void SetDictonery()
        {
            counter = 0;
            foreach (string line in File.ReadAllLines(this.fileName))
            {
                try
                {
                    dictHighScore.Add(int.Parse(line.Split(',')[1]) <= 1 ? int.MinValue+20 : int.Parse(line.Split(',')[1]), line.Split(',')[0]);
                }
                catch
                {
                    int temp = 0;
                    do
                    {
                        if (++temp > 10) break;

                    } while (dictHighScore.Keys.Contains<int>(temp + ((int.Parse(line.Split(',')[1]) <= 1) ? int.MinValue + 20 : int.Parse(line.Split(',')[1]))));
                    dictHighScore.Add((temp + ((int.Parse(line.Split(',')[1]) <= 1) ? int.MinValue + 20 : int.Parse(line.Split(',')[1]))), line.Split(',')[0]);
                }
                if (counter++ == 10) break;
            }
        }

        private void SetValuesInFile()
        {
            string[] temp = new string[10];

            if (!File.Exists(this.fileName))
            {
                File.Create(this.fileName).Close();

                for (int i = 0; i < 10; i++)
                {
                    temp[i] = ((char)(i + 65) + "," + "1").ToString();
                }

                File.WriteAllLines(fileName, temp);
            }
            if (dictHighScore.Count != 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    temp[i] = (dictHighScore.Values.ElementAt<string>(i) + "," + dictHighScore.Keys.ElementAt<int>(i)).ToString();
                }
                File.WriteAllLines(fileName, temp);
            }
        }

        private void LblSendmail_Click(object sender, EventArgs e)
        {
            inputForm = new InputForm("Enter an Email");
            string mailBody = "";
            if (inputForm.Start())
            {
                try
                {
                    counter = 0;
                    foreach (string line in File.ReadAllLines(this.fileName).Reverse<string>())
                    {
                        int foo;
                        int.TryParse(line.Split(',')[1],out foo);
                        if (foo <= 1) break;
                        mailBody += (++counter).ToString() + ")" + line.Replace(",", "........") + "<br>";
                    }
                }
                catch
                {

                }
                switch (Player.SendEmail(mailBody))
                {
                    case 1:
                        break;
                    case 2:
                        if (Player.MailTo != null)
                        {
                            MessageBox.Show("Invalid Email address!\nCall the SWAT Team! ");
                        }
                        this.LblSendmail_Click(sender, e);
                        break;
                    case 3:
                        if (Player.MailTo != null)
                            MessageBox.Show("Sorry, network problem!\nCall the SWAT Team!");
                        break;

                }
                Player.MailTo = "";
            }
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
            f.ShowDialog();
            this.Hide();
            this.Close();

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HighScore
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Name = "HighScore";
            this.ResumeLayout(false);

        }
    }
}
