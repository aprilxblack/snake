using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{

    public enum GameState
    {
        Menu, Playing, GameOver
    }


    class Game
    {
        
        public Snake snake { get; private set; }
        public Reward reward { get; private set; }
        public int score { get; private set; } = 0;

        DateTime start = DateTime.Now;

        int sizeX, sizeY;


        public Game(int sizeX, int sizeY)
        {
            snake = new Snake(sizeX, sizeY);
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            reward = new Reward(sizeX, sizeY);
        }

        public void Run()
        {

            GameState state = GameForm.State;
            if (state == GameState.Playing)
            {

                if (start <= DateTime.Now.Subtract(TimeSpan.FromSeconds(10)))
                {
                    reward = new Reward(sizeX, sizeY);
                    start = DateTime.Now;
                }
                
                snake.Tick();
                EatReward();
                
            }
            
        }

        public void EatReward()
        {
            if (snake.segmentPositions[0].Equals(reward.rewardPlace))
            {
                if (reward.rewardValue == 0)
                {
                    score = 0;
                    snake.ResetSnake();
                }
                else
                {
                    score += reward.rewardValue;
                    snake.segmentPositions.Add(new Point(snake.segmentPositions[0].X, snake.segmentPositions[0].Y));
                }
                reward = new Reward(sizeX, sizeY);
                start = DateTime.Now;

            }
            
        }
        

    }
}
