using System.Collections.Generic;

namespace BeatBall
{
    class Level
    {
        /**************Fields***************/
        
        // The time for finish level // 
        public int MyTime { get; set; }

        // Bricks list of level // 
        public List<Brick> Bricks = new List<Brick>();

        /*************Constructor*****************/
        /// <summary>
        /// bulit al level
        /// </summary>
        /// <param name="timeInSec">represent the time in sec</param>
        /// <param name="bricks">array of all the bricks in the level</param>
        /// 
        public Level(int timeInSec, params Brick[] bricks)
        {
            this.MyTime = timeInSec;
            if(bricks!=null)
            foreach (Brick b in bricks)
            {
                    if(b!=null)
                this.Bricks.Add(b);
            }
        }

    }
}
