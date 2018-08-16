using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake2
{
    public partial class GameForm : Form
    {
        // Last pressed key to be processed
        public static Keys? pressedKey = null;

        // Board size
        public static int SizeX = 60, SizeY = 60;

        public static GameState State { get; set; } = GameState.Menu;

        private Game game;

        public GameForm()
        {
            InitializeComponent();

            MenuPanel.Location = new Point(12, 12);
            GamePanel.Location = MenuPanel.Location;

            Timer tickTimer = new Timer();
            tickTimer.Interval = 100;
            tickTimer.Tick += TickTimer_Tick;
            tickTimer.Start();

            ToggleGamePanel(false);
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            if(game != null)
            {
                game.Run();
                DrawGame();

                lblScore.Text = "Score: " + game.score;
            }

            if (State == GameState.GameOver)
            {
                // Game over
                GameOverPanel.Visible = true;
                GamePanel.Visible = true;
                MenuPanel.Visible = false;
                gameCanvas.Visible = false;
            }
        }

        public void ToggleGamePanel(bool gameOn)
        {
            GamePanel.Visible = gameOn;
            MenuPanel.Visible = !gameOn;
            GameOverPanel.Visible = false;
        }

        public void NewGame()
        {
            ToggleGamePanel(true);
            gameCanvas.Visible = true;

            State = GameState.Playing;
            // 10 pixels per snake grid segment
            game = new Game(gameCanvas.Width/10, gameCanvas.Height/10);

            DrawGame();
        }

        private void DrawGame() {
        
            // Create new image for displaying inside game canvas picture box
            Bitmap bitmap = new Bitmap(gameCanvas.Width, gameCanvas.Height);
            Graphics g = Graphics.FromImage(bitmap);

            int scale = 10;
            int size = 8;

            foreach(Point segment in game.snake.segmentPositions)
            {
                g.FillRectangle(Brushes.White, new Rectangle(segment.X*scale + 3, segment.Y*scale +3, size, size));
                g.FillRectangle(Brushes.Black, new Rectangle(segment.X * scale + size/4 + 3, segment.Y * scale + size/4 + 3, size/2, size/2));
            }


            // Draw outline
            g.DrawRectangle(Pens.DarkCyan, 7, 7, bitmap.Width - 15, bitmap.Height - 15);
            g.DrawRectangle(Pens.DarkCyan, 8, 8, bitmap.Width - 17, bitmap.Height - 17);

            Brush rewardBrush = Brushes.White;
            if(game.reward.rewardValue == 0)
            {
                rewardBrush = Brushes.Red;
            }

            g.DrawString(game.reward.rewardValue.ToString(), new Font(FontFamily.GenericMonospace, 11), rewardBrush, game.reward.rewardPlace.X *scale - 1, game.reward.rewardPlace.Y * scale - 2);
            
            // Update displayed image with generated one
            gameCanvas.Image = bitmap;

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKey = e.KeyCode;
        }
    }
}
