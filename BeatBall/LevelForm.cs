using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace BeatBall
{
    public partial class LevelForm : Form
    {
        private List<Level> levelsList = new List<Level>();

        private int activeLevel = 0;
        private const int X_GAP = 30;
        private const int Y_GAP = 30;
        private int currentLevelTime = 0;
        public int NumOfBricksLeft { get; set; } = 0;

        private Label lblScore = new Label();
        private Label lblTime = new Label();
        private Label lblStrikes = new Label();
        private Label lblLevel = new Label();

        /// <summary>
        /// main paly form
        /// </summary>
        public LevelForm()
        {
            InitializeComponent();
            if (activeLevel == 0)
            {
                this.setLevels();
            }
            this.loadLevel(activeLevel);
        }
        /// <summary>
        /// load level to the form
        /// </summary>
        /// <param name="levelIndex">this level's activeLevel</param>
        private void loadLevel(int levelIndex)
        {
            //InitializeComponent();
            Player.myBall = new Ball(30);

            Player.myPaddle.Location = new Point(this.ClientRectangle.Width / 2 - 35, this.ClientRectangle.Height - Player.myPaddle.Height - 10);
            Player.myBall.Location = new Point(this.ClientRectangle.Width / 2 - 35, this.ClientRectangle.Height - Player.myPaddle.Height - Player.myBall.Height - 50);
            if (NumOfBricksLeft == 0)
            {
                this.NumOfBricksLeft = this.levelsList.ElementAt<Level>(activeLevel).Bricks.Count;// add all the bricks
                foreach (Brick b in this.levelsList[levelIndex].Bricks)
                {
                    this.Controls.Add(b);
                    if (b.Unbreakable)
                    {
                        this.NumOfBricksLeft--;
                    }
                }
                this.currentLevelTime = this.levelsList.ElementAt<Level>(activeLevel).MyTime; // get the level's time in sec
            }
            this.lblStrikes.Text = Player.Strikes.ToString() + " strike" + (Player.Strikes > 1 ? "s" : "");
            this.lblStrikes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));

            if (!this.Controls.Contains(Player.myBall))
            {

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Ball)
                    {
                        this.Controls.Remove(ctrl);
                    }
                }
                this.Controls.Add(Player.myBall); // add the ball
            }
            this.Controls.Add(Player.myPaddle); // add the padlle
            this.lblTime.Location = new Point(3, 3);
            this.lblLevel.Text = "Level: " + (1+activeLevel).ToString();
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLevel.Location = new Point(3, this.ClientRectangle.Height-this.lblLevel.Height-3);
            this.lblStrikes.Location = new Point((this.ClientRectangle.Width - lblStrikes.Width) / 2, 3);
            this.lblTime.BackColor = Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTime);
            this.lblScore.Location = new Point(this.ClientRectangle.Width - this.lblScore.PreferredWidth -3, 3);
            this.lblScore.BackColor = Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblStrikes.ForeColor = Color.White;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblStrikes);
            this.Controls.Add(this.lblLevel);
        }
        /// <summary>
        /// main timer control on all the game's movment
        /// </summary>
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            Player.myBall.Move();
            if (this.currentLevelTime <= 0)
            {
                this.Lose();
            }

            this.lblTime.Text = ((int)this.currentLevelTime / 60).ToString() + ":" +
                               (((this.currentLevelTime % 60) < 10) ? ("0" + this.currentLevelTime % 60).ToString()
                                                                              : (this.currentLevelTime % 60).ToString());
            this.lblScore.Text = "Score: " + Player.Score.ToString();
            if (this.NumOfBricksLeft == 0)
            {
                try
                {
                    this.loadLevel(++activeLevel); //load the next level.   
                }
                catch (System.Exception)
                {
                    this.EndOfTheGame();
                }
            }
        }
        /// <summary>
        /// check when the padlle shuld go left or rigth
        /// </summary>
        private void LevelForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (this.mainTimer.Enabled)
                        Player.myPaddle.MoveLeft();
                    break;
                case Keys.Right:
                    if (this.mainTimer.Enabled)
                        Player.myPaddle.MoveRight();
                    break;
                case Keys.Escape:
                    {
                        this.mainTimer.Stop();
                        secTimer.Stop();
                        this.EndOfTheGame();
                    }
                    break;
                case Keys.Space:
                    if (this.mainTimer.Enabled)
                    {
                        this.mainTimer.Stop();
                        this.secTimer.Stop();
                        this.Controls.Add(new Label()
                        {
                            Text = "Pause!",
                            Location = new Point(this.ClientRectangle.Width / 2 - 14, this.ClientRectangle.Height / 2 - 14),
                            ForeColor = Color.White,
                            Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)))
                        });
                    }
                    else
                    {
                        this.mainTimer.Start();
                        this.secTimer.Start();
                        this.Controls.RemoveAt(Controls.Count - 1);
                    }
                    break;
            }
        }
        /// <summary>
        /// called when the palyer lost in one round (by time or that the ball fall down)
        /// </summary>
        public void Lose()
        {
            this.mainTimer.Stop();
            this.secTimer.Stop();
            if (Player.Strikes > 0)
            {
                if (--Player.Strikes != 0)
                {
                    this.loadLevel(this.activeLevel);
                    this.mainTimer.Start();
                    this.secTimer.Start();
                }
                else
                {
                    this.EndOfTheGame();
                }
            }
        }
        /// <summary>
        /// called when level is pass.
        /// </summary>
        private void LevelPass()
        {
            this.mainTimer.Stop();
            this.secTimer.Stop();
            Player.Score += (int)(Math.Sqrt(Math.Abs(levelsList.ElementAt<Level>(activeLevel).MyTime))); // bonus for fast players
        }

        private void EndOfTheGame()
        {
            this.mainTimer.Stop();
            this.secTimer.Stop();
            Form f = new HighScore();
            this.Close();
            this.Hide();
            f.ShowDialog();
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            this.currentLevelTime--;
        }

        private void LevelForm_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (Player.myPadlle != null)
             Player.myPadlle.Left = e.X - 64;*/
        }
    }
}

