using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Media;

namespace BeatBall
{
    public class Ball : PictureBox
    {
        //************Fields**************//
        
        // Ball's radius //
        private int myRadius;

        // Ball's speed in dim X //
        private int ballSpeedX;

        // Ball's speed in dim Y //
        private int ballSpeedY;

        // The interaction's sound between ball and paddle //
        private SoundPlayer soundPlayer = new SoundPlayer(BeatBall.Properties.Resources.Hit_Paddle);

        // Bool field that return True if the ball go left in the last time // 
        private bool goLeft = true; 

        // Bool field that return True if the ball go up in the last time // 
        private bool goUp = false;

        // The constant speed of the ball //
        private const int TOTAL_SPEED = 21;

        /*************************\
        |******constractors*******|
        \*************************/
        public Ball(int radius) : base()
        {
            this.Image = BeatBall.Properties.Resources.Ball;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.myRadius = radius;
            this.Height = radius * 2;
            this.Width = radius * 2;
            this.ballSpeedX = (int)Math.Sqrt(2) * TOTAL_SPEED;
            this.ballSpeedY = this.ballSpeedX;
        }

        /***********************\
        |********methods********|
        \***********************/
        /// <summary>
        /// set the ball as round shape.
        /// </summary>
        protected override void OnResize(EventArgs e) //make the ball round
        {
            base.OnResize(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
        /// <summary>
        /// Move the ball by movement in Dimension X & Dimension Y.
        /// </summary>
        public new void Move()
        {
            foreach (Control ctrl in (this.FindForm()).Controls)
            {
                // check if the ball is in interaction with object
                if (this.Bounds.IntersectsWith(ctrl.Bounds))
                {
                    if (ctrl is Paddle || ctrl is Brick)
                    {
                        this.ballSpeedY = (int)Math.Abs((TOTAL_SPEED * Math.Sin(CalculateAngle(ctrl))));
                        this.ballSpeedX = (int)Math.Abs(Math.Sqrt(Math.Pow(TOTAL_SPEED, 2) - Math.Pow(this.ballSpeedY, 2)));

                        while (Math.Abs(this.ballSpeedX) < (TOTAL_SPEED / 4)) // בודק שלא ינוע רק על ציר Y
                        {
                            this.ballSpeedX++;
                            this.ballSpeedY--;
                        }
                        while (Math.Abs(this.ballSpeedY) < (TOTAL_SPEED / 4)) // בודק שלא נע רק על ציר X
                        {
                            this.ballSpeedX--;
                            this.ballSpeedY++;
                        }

                        if (this.IsBetween(ctrl.Left - myRadius / 2, Average(this.Right, this.Left), ctrl.Right + myRadius / 2)) // פגיעה אנכית
                        {
                            if (this.Top > ctrl.Top) this.ballSpeedY = Math.Abs(this.ballSpeedY); // פגיעה מלמטה
                            else if (this.Bottom<ctrl.Bottom) this.ballSpeedY = -1 * Math.Abs(this.ballSpeedY); // פגיעה מלמעלה

                            if (goLeft)
                            {
                                this.ballSpeedX = -1 * Math.Abs(this.ballSpeedX);
                            }
                        }

                       if (this.IsBetween(ctrl.Top - myRadius / 2, Average(this.Top, this.Bottom), ctrl.Bottom + myRadius / 2)) // פגיעה אופקית
                        {

                            if (this.Right > ctrl.Right) this.ballSpeedX = Math.Abs(this.ballSpeedX); //פגיעה מימין
                            else if (this.Left < ctrl.Left) this.ballSpeedX = -1 * Math.Abs(this.ballSpeedX); //פגיעה משמאל
                            if (goUp)
                            {
                                this.ballSpeedY= - 1 * Math.Abs(this.ballSpeedY);
                            }

                        }
                        if (ctrl is Brick)
                        {
                            ((Brick)ctrl).Hit();
                        }
                        else if (ctrl is Paddle)
                        {
                            if (Setting.audioIsOn) soundPlayer.Play(); // play sound
                        }
                    }
                }
            }
            // check if the ball in area of screen ! 
            if ((this.Left > (this.FindForm()).ClientRectangle.Width - this.Width) || this.Left <= 1) // פגיעה בצדדי המסך
            {
                this.ballSpeedX *= -1;
            }

            if (this.Top <= 1) this.ballSpeedY *= -1; // פגיעה בחלק העליון של המסך

            if (this.Top > (this.FindForm()).ClientRectangle.Height) //the ball is out of the rectangle (bottom)
                ((LevelForm)(this.FindForm())).Lose(); // הכדור נפל

            this.Top += ballSpeedY;
            this.Left += ballSpeedX;

            this.goLeft = this.ballSpeedX < 0;
            this.goUp = this.ballSpeedY < 0;
        }

        /// <summary>
        /// calculate the angle between the ball and the brick or the paddle
        /// </summary>
        /// <param name="ctrl">get the brick or the padlle</param>
        /// <returns></returns>
        private double CalculateAngle(Control ctrl)
        {
            double angle;
            try
            {
                double h = Average(this.Top, this.Bottom) - Average(ctrl.Top, ctrl.Bottom);
                double d = Average(this.Left, this.Right) - Average(ctrl.Left, ctrl.Right);
                angle = Math.Atan(h / d);
            }
            catch
            {
                return Math.PI / 4;
            }

            return (angle == 0) ? Math.PI / 8 : angle;
        }
        /// <summary>
        /// return the average from tow nums
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private double Average(double a, double b)
        {
            return (a + b) / 2;
        }
        /// <summary>
        /// return true if the mid number is between the tow other nums
        /// </summary>
        /// <param name="left">left side</param>
        /// <param name="mid">mid </param>
        /// <param name="right">rigth side</param>
        /// <returns>bool</returns>
        private bool IsBetween(double left, double mid, double right)
        {
            return ((mid <= right) && (mid >= left)) || ((mid <= left) && (mid >= right));
        }
    }
}
// end class Ball //
