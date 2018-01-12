namespace BlackJackGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gameCanvas = new System.Windows.Forms.PictureBox();
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.yourScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.drawCardLabel = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.enemyMoveLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.restartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.Location = new System.Drawing.Point(24, 53);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(1200, 600);
            this.gameCanvas.TabIndex = 0;
            this.gameCanvas.TabStop = false;
            this.gameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCanvas_Paint);
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScoreLabel.Location = new System.Drawing.Point(876, 377);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(221, 46);
            this.yourScoreLabel.TabIndex = 1;
            this.yourScoreLabel.Text = "Your Score";
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.AutoSize = true;
            this.dealerScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScoreLabel.Location = new System.Drawing.Point(856, 82);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(254, 46);
            this.dealerScoreLabel.TabIndex = 2;
            this.dealerScoreLabel.Text = "Dealer Score";
            // 
            // yourScore
            // 
            this.yourScore.AutoSize = true;
            this.yourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourScore.Location = new System.Drawing.Point(984, 455);
            this.yourScore.Name = "yourScore";
            this.yourScore.Size = new System.Drawing.Size(0, 46);
            this.yourScore.TabIndex = 3;
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScore.Location = new System.Drawing.Point(984, 153);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(0, 46);
            this.dealerScore.TabIndex = 4;
            // 
            // drawCardLabel
            // 
            this.drawCardLabel.AutoSize = true;
            this.drawCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawCardLabel.Location = new System.Drawing.Point(182, 298);
            this.drawCardLabel.Name = "drawCardLabel";
            this.drawCardLabel.Size = new System.Drawing.Size(335, 31);
            this.drawCardLabel.TabIndex = 5;
            this.drawCardLabel.Text = "Press Space to Draw Card";
            this.drawCardLabel.Visible = false;
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishLabel.Location = new System.Drawing.Point(236, 355);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(212, 31);
            this.finishLabel.TabIndex = 6;
            this.finishLabel.Text = "Press N to finish";
            this.finishLabel.Visible = false;
            // 
            // enemyMoveLabel
            // 
            this.enemyMoveLabel.AutoSize = true;
            this.enemyMoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMoveLabel.Location = new System.Drawing.Point(140, 251);
            this.enemyMoveLabel.Name = "enemyMoveLabel";
            this.enemyMoveLabel.Size = new System.Drawing.Size(426, 31);
            this.enemyMoveLabel.TabIndex = 7;
            this.enemyMoveLabel.Text = "Press Space for next enemy Move";
            this.enemyMoveLabel.Visible = false;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(284, 106);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(120, 38);
            this.winnerLabel.TabIndex = 8;
            this.winnerLabel.Text = "Winner";
            this.winnerLabel.Visible = false;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartLabel.Location = new System.Drawing.Point(139, 161);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(382, 38);
            this.restartLabel.TabIndex = 9;
            this.restartLabel.Text = "Press Enter to play again";
            this.restartLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 742);
            this.Controls.Add(this.restartLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.enemyMoveLabel);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.drawCardLabel);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.yourScore);
            this.Controls.Add(this.dealerScoreLabel);
            this.Controls.Add(this.yourScoreLabel);
            this.Controls.Add(this.gameCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameCanvas;
        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label dealerScoreLabel;
        private System.Windows.Forms.Label yourScore;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label drawCardLabel;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Label enemyMoveLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label restartLabel;
    }
}

