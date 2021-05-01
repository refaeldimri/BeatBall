using System;
using System.Windows.Forms;
using System.Drawing;

namespace BeatBall
{
    public class Brick : PictureBox
    {
        //***************Fields*****************//

        // Brick's immunity //
        private Byte immunityLevel = 1;

        // true only if the brick is immune //
        public bool Unbreakable { get; private set; } = false;
        
        // The height of brick //
        internal static int brickHeight = Screen.PrimaryScreen.Bounds.Height / 12 -30;

        // The width of brick //
        internal static int brickWidth = Screen.PrimaryScreen.Bounds.Width /6 -40;

        /*************************\
        |******constractors*******|
        \*************************/

        /// <summary>
        /// Byte immunityLevel present how many times the ball should hit the brick.
        /// </summary>
        public Brick(Point myLocation, Byte immunityLevel)
        {
            this.Height = brickHeight;
            this.Width = brickWidth;
            this.Location = myLocation;
            this.immunityLevel = immunityLevel > (Byte)4 ? (Byte)4 : immunityLevel;
            this.SetColor();
        }

        /// <summary>
        /// <param name="unbreakable">
        /// unbreakable true only if the brick is immune.
        /// </param>
        /// </summary>
        public Brick(Point myLocation, bool Unbreakable)
        {
            this.Unbreakable = Unbreakable;
            this.Height = brickHeight;
            this.Width = brickWidth;
            this.Location = myLocation;
            this.SetColor();
        }

        /***********************\
        |********methods********|
        \***********************/
        /// <summary>
        /// set the color of the brick depending on its strength.
        /// </summary>
        private void SetColor()
        {
            if (Unbreakable)
            {
                this.Image = BeatBall.Properties.Resources.GrayBrick;
                this.BackColor = Color.Gray;
            }
            else
            {
                switch (this.immunityLevel)
                {
                    case (1):
                        this.Image = BeatBall.Properties.Resources.GreenBrick;
                        this.BackColor = Color.Green;
                        break;
                    case (2):
                        this.Image = BeatBall.Properties.Resources.YellowBrick;
                        this.BackColor = Color.Yellow;
                        break;
                    case (3):
                        this.Image = BeatBall.Properties.Resources.OrangeBricks;
                        this.BackColor = Color.Orange;
                        break;
                    case (4):
                        this.Image = BeatBall.Properties.Resources.RedBrick;
                        this.BackColor = Color.Red;
                        break;
                    default:
                        this.BackColor = Color.Black;
                        break;
                }
            }
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Check the brick's Findings and reaction accordingly
        /// </summary
        public void Hit()
        {
            if (!(this.Unbreakable))
            {
                if (this.immunityLevel==1)
                {
                    ((LevelForm)(this.FindForm())).NumOfBricksLeft--;
                    Player.Score += 2;
                    (this.FindForm()).Controls.Remove(this);
                }
                else
                    Player.Score++;
                    this.immunityLevel--;
                this.SetColor();
            }
        }
    }
}
