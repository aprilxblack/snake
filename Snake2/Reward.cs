using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Reward
    {
        
        public Point rewardPlace;
        public int rewardValue = 0;

        public Reward(int sizeX, int sizeY)
        {
            Random rand = new Random();
            int x = rand.Next(2, sizeX - 1);
            int y = rand.Next(2, sizeY - 1);
            rewardPlace = new Point(x,y);
            rewardValue = rand.Next(-1, 10);

            if (rewardValue < 0)
            {
                rewardValue = 0;
            }
        }

    }
}
