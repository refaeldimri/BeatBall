using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BeatBall
{
    partial class LevelForm
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Timer mainTimer = new Timer();
        private Timer secTimer = new Timer();
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       private void InitializeComponent()
       {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 20;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // seecTimer
            // 
            this.secTimer.Enabled = true;
            this.secTimer.Interval = 1000;
            this.secTimer.Tick += new System.EventHandler(this.secTimer_Tick);
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelForm";
            this.Text = "LevelForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelForm_MouseMove);
            this.ResumeLayout(false);

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

        }

        /// <summary>
        /// this method set the level's bricks order.
        /// </summary>
        private void setLevels()
        {
            PictureBox[] tempBricks = new Brick[36];
            // set level 1
            int i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X <6; X++)
                {
                    tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 1);
                }
            }
            this.levelsList.Add(new Level(150, (Brick[])tempBricks));

            //set level 2
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 2);
                    }else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 3);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 1);
                    }
                }
            }
            this.levelsList.Add(new Level(150, (Brick[])tempBricks));

            //set level 3
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 3);
                    }
                    else if (X + Y % 5 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 4);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 2);
                    }
                }
            }
            this.levelsList.Add(new Level(150, (Brick[])tempBricks));

            //set level 4
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 1))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 3);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 2);
                    }
                }
            }
            this.levelsList.Add(new Level(130, (Brick[])tempBricks));

            //set level 5
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 4 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 2);
                    }
                    else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 3);
                    }
                }
            }
            this.levelsList.Add(new Level(130, (Brick[])tempBricks));

            //set level 6
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 2);
                    }
                    else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 3);
                    }
                }
            }
            this.levelsList.Add(new Level(130, (Brick[])tempBricks));

            //set level 7
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 1);
                    }
                }
            }
            this.levelsList.Add(new Level(120, (Brick[])tempBricks));

            //set level 8
            i = 0;
            for (int Y = 0; Y < 5; Y++)
            {
                for (int X = 0; X < 6; X++)
                {
                    if ((Y + X % 2 == 0))
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), true);
                    }
                    else if (X + Y % 3 == 0)
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 4);
                    }
                    else
                    {
                        tempBricks[i++] = new Brick(new Point(X_GAP + (Brick.brickWidth + X_GAP) * X, (Brick.brickHeight + Y_GAP) * Y + Y_GAP), 4);
                    }
                }
            }
            this.levelsList.Add(new Level(120, (Brick[])tempBricks));
        }

        #endregion

        private System.ComponentModel.IContainer components;

    }
}