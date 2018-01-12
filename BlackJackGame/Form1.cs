using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJackGame.Classes;

namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        private Table table;
        //private Deck deck;


        //only need keys on UP position so it does not react more than once per cycle
        private bool keyContinue = false;
        private bool keyStop = false;
        private bool keyEnter = false;

        public Form1()
        {
            InitializeComponent();

            gameTimer.Interval = 30;
            gameTimer.Tick += Update;
            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            //new session stats
            new Stats();

            table = new Table();
            table.Create(); // creates deck and shuffles

            table.PlayerInitialDraw();
            table.DealerInitialDraw();
            table.InitialCount();
        }

        private void Update(object sender, EventArgs e)
        {
            if(!Stats.GameOver)
            {
                if (Stats.isPlayerTurn)
                {
                    drawCardLabel.Visible = true;
                    finishLabel.Visible = true;
                    if (keyContinue) // take card
                    {
                        //show draw key label
                        Console.WriteLine("Drawing Card!");
                        table.PlayerDraw();
                        
                        //count value
                    }
                    else if (keyStop) // pass on card
                    {
                        //calculate score and let the enemy go

                        //hide labels
                        drawCardLabel.Visible = false;
                        finishLabel.Visible = false;

                        //null your card
                        //table.playerCard = null;

                        //switch players
                        table.CountDealer();
                        Stats.ChangeTurns();
                    }
                } else //dealer moves
                {
                    enemyMoveLabel.Visible = true;
                    drawCardLabel.Visible = false;
                    finishLabel.Visible = false;
                    if (keyContinue)
                    {
                        //think what the enemy will do

                        //dummy draw card
                        table.DealerDraw();
                    }
                }
               
            } else
            {
                //hide previous labels
                enemyMoveLabel.Visible = false;
                drawCardLabel.Visible = false;
                finishLabel.Visible = false;

                //show winner and restart labels
                winnerLabel.Text = Stats.Winner;
                winnerLabel.Visible = true;
                restartLabel.Visible = true;

                if (keyEnter)
                {
                    winnerLabel.Visible = false;
                    restartLabel.Visible = false;
                    StartGame();
                }
            }

            //restore keys
            keyContinue = false;
            keyStop = false;
            keyEnter = false;

            //update scores
            yourScore.Text = Stats.YourCardScore.ToString();
            dealerScore.Text = Stats.DealerCardScore.ToString();

            //update GUI
            gameCanvas.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Input.ChangeState(e.KeyCode, true);
            //if (e.KeyCode == Keys.Space)
            //    keyContinue = true;
            //if (e.KeyCode == Keys.N)
            //    keyStop = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Input.ChangeState(e.KeyCode, false);
            if (e.KeyCode == Keys.Space)
                keyContinue = true;
            if (e.KeyCode == Keys.N)
                keyStop = true;
            if (e.KeyCode == Keys.Enter)
                keyEnter = true;
        }

        private void gameCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            table.Draw(g);

            //paint deck, cards
            //if (table.playerCard != null)
            //{
            //    //Console.WriteLine("Painting player card");
            //    table.playerCard.Draw(g);
            //}

            //if (table.dealerCard != null)
            //{
            //    //Console.WriteLine("Painting player card");
            //    table.dealerCard.Draw(g);
            //}

        }
    }
}
