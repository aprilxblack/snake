namespace Snake2
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.gameOverButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.GameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.label5);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.btnNewGame);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Location = new System.Drawing.Point(24, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(610, 587);
            this.MenuPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = "Collect digits to score and extend your snake\r\nAvoid 0 or your score and snake wi" +
    "ll be reset";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "by Karolina Zdziarska";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNewGame.Location = new System.Drawing.Point(230, 331);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(183, 38);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Start new game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Snake";
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.gameCanvas);
            this.GamePanel.Controls.Add(this.lblScore);
            this.GamePanel.Location = new System.Drawing.Point(0, 27);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(610, 587);
            this.GamePanel.TabIndex = 6;
            // 
            // gameCanvas
            // 
            this.gameCanvas.Location = new System.Drawing.Point(8, 8);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(594, 545);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(21, 556);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 18);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.Controls.Add(this.gameOverButton);
            this.GameOverPanel.Controls.Add(this.label4);
            this.GameOverPanel.Location = new System.Drawing.Point(12, 12);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(560, 416);
            this.GameOverPanel.TabIndex = 3;
            // 
            // gameOverButton
            // 
            this.gameOverButton.Location = new System.Drawing.Point(251, 290);
            this.gameOverButton.Name = "gameOverButton";
            this.gameOverButton.Size = new System.Drawing.Size(131, 35);
            this.gameOverButton.TabIndex = 1;
            this.gameOverButton.Text = "Start new game";
            this.gameOverButton.UseVisualStyleBackColor = true;
            this.gameOverButton.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(209, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Game Over!";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.GamePanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.Name = "GameForm";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.Button gameOverButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

