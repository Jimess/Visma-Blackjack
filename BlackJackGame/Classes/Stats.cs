using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Classes
{
    class Stats
    {
        public static bool GameOver { get; set; }
        public static int YourCardScore { get; set; }
        public static int DealerCardScore { get; set; }
        public static bool isPlayerTurn { get; set; }
        public static bool CardTake { get; set; }
        public static string Winner { get; set; }
        public static bool playerLost { get; set; }

        public Stats()
        {
            GameOver = false;
            isPlayerTurn = true;
            CardTake = false;
            YourCardScore = 0;
            DealerCardScore = 0;
            playerLost = false;
        }


        public static void PlayerWins()
        {
            GameOver = true;
            Winner = "Player Wins!";
            //Console.WriteLine("PlayerWins!");
        }

        public static void DealerWins()
        {
            GameOver = true;
            Winner = "Dealer Wins!";
            //Console.WriteLine("DealerWins!");
        }

        public static void Draw()
        {
            GameOver = true;
            Winner = "Draw!";
            //Console.WriteLine("Both lose");
        }

        public static void CountWinner()
        {
            int playerAbs = Math.Abs(21 - YourCardScore);
            int dealerAbs = Math.Abs(21 - DealerCardScore);

            if ((DealerCardScore > 21 && YourCardScore > 21) || (DealerCardScore <= 21 && YourCardScore <= 21))
            {
                if (playerAbs < dealerAbs)
                {
                    PlayerWins();
                }
                else if (playerAbs > dealerAbs)
                {
                    DealerWins();
                }
                else
                {
                    Draw();
                }
            } else if (DealerCardScore <= 21 && YourCardScore > 21)
            {
                if (DealerCardScore >= 17)
                {
                    DealerWins();
                }
            } else if (DealerCardScore > 21 && YourCardScore <= 21)
            {
                if (YourCardScore >= 17)
                {
                    PlayerWins();
                }
            } 
        }

        public static void ChangeTurns()
        {
            isPlayerTurn = !isPlayerTurn;
        }
    }
}
