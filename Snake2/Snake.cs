using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace Snake2
{
    class Snake
    {
        public List<Point> segmentPositions = new List<Point>();

        TimeSpan interval = new TimeSpan(0, 0, 0, 0, 100);

        public ConsoleKey key = ConsoleKey.RightArrow;

        private int sizeX, sizeY;

        public Snake(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;

            for (int i = 0; i < 6; i++)
            {
                segmentPositions.Add(new Point(sizeX / 2 - i, sizeY / 2));
            }

        }

        public bool Tick()
        {

            for (int i = segmentPositions.Count - 1; i >= 1; i--)
            {
                segmentPositions[i] = new Point(segmentPositions[i - 1].X, segmentPositions[i - 1].Y);
                
            }

            HandleInput();
            
            if (DidSnakeCollide() || DidSnakeEatItself())
            {
                GameForm.State = GameState.GameOver;

                return false;
            }

            return true;
        }

        public bool DidSnakeEatItself()
        {
            for(int i = 1; i < segmentPositions.Count; i++)
            {
                if(segmentPositions[0].X == segmentPositions[i].X && segmentPositions[0].Y == segmentPositions[i].Y)
                {
                    return true;
                }
               
            }
            return false;
        }

        public bool DidSnakeCollide()
        {
            return segmentPositions[0].X == sizeX-1 || segmentPositions[0].Y == sizeY-1
                || segmentPositions[0].X == 0 || segmentPositions[0].Y == 0;
        }

        public void HandleInput()
        {

            while (GameForm.pressedKey.HasValue)
            {
                ConsoleKey newKey = key;
                switch(GameForm.pressedKey.Value)
                {
                    case System.Windows.Forms.Keys.Up:
                        newKey = ConsoleKey.UpArrow;
                        break;
                    case System.Windows.Forms.Keys.Down:
                        newKey = ConsoleKey.DownArrow;
                        break;
                    case System.Windows.Forms.Keys.Right:
                        newKey = ConsoleKey.RightArrow;
                        break;
                    case System.Windows.Forms.Keys.Left:
                        newKey = ConsoleKey.LeftArrow;
                        break;

                    default:
                        break;
                }

                GameForm.pressedKey = null;

                if (
                    (key == ConsoleKey.RightArrow && newKey != ConsoleKey.LeftArrow) ||
                    (key == ConsoleKey.LeftArrow && newKey != ConsoleKey.RightArrow) ||
                    (key == ConsoleKey.UpArrow && newKey != ConsoleKey.DownArrow) ||
                    (key == ConsoleKey.DownArrow && newKey != ConsoleKey.UpArrow)
                    )
                {
                    key = newKey;
                }
            }

            switch (key)
            {
                case ConsoleKey.RightArrow:
                    segmentPositions[0] = new Point(segmentPositions[0].X + 1, segmentPositions[0].Y);
                    break;

                case ConsoleKey.LeftArrow:
                    segmentPositions[0] = new Point(segmentPositions[0].X - 1, segmentPositions[0].Y);
                    break;
                case ConsoleKey.UpArrow:
                    segmentPositions[0] = new Point(segmentPositions[0].X, segmentPositions[0].Y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    segmentPositions[0] = new Point(segmentPositions[0].X, segmentPositions[0].Y + 1);
                    break;
            }

        }

        public void ResetSnake()
        {
            segmentPositions.RemoveRange(6, segmentPositions.Count - 6);

        }
        
    }
}
