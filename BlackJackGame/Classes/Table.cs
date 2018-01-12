using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Classes
{
    class Table : Drawable
    {
        public Deck deck;
        public List<Card> playerCards = new List<Card>();
        public List<Card> dealerCards = new List<Card>();

        public void Create()
        {
            deck = new Deck();
            deck.Build();
        }

        public void PlayerInitialDraw()
        {
            Card tmp = deck.GetTopCard();
            playerCards.Add(tmp);
            Stats.YourCardScore += tmp.Value;

            tmp = deck.GetTopCard();
            playerCards.Add(tmp);
            Stats.YourCardScore += tmp.Value;
        }

        public void DealerInitialDraw()
        {
            Card tmp = deck.GetTopCard();
            dealerCards.Add(tmp);
            Stats.DealerCardScore += tmp.Value;

            tmp = deck.GetTopCard();
            dealerCards.Add(tmp);
            Stats.DealerCardScore += tmp.Value;
        }

        public void PlayerDraw()
        {
            Card tmp = deck.GetTopCard();
            playerCards.Add(tmp);
            Stats.YourCardScore += tmp.Value;

            CountPlayer();
        }

        public void DealerDraw()
        {
            Card tmp = deck.GetTopCard();
            dealerCards.Add(tmp);
            Stats.DealerCardScore += tmp.Value;
            

            CountDealer();

        }

        public int GetDealerAlternate()
        {
            int tempval = 0;
            foreach (Card c in dealerCards)
            {
                if (c.Name == Card.Cards.ACE.ToString())
                    tempval += c.AlternativeValue;
                else
                    tempval += c.Value;
            }
            return tempval;
        }

        public int GetPlayerAlternate()
        {
            int tempval = 0;
            foreach (Card c in playerCards)
            {
                if (c.Name == Card.Cards.ACE.ToString())
                    tempval += c.AlternativeValue;
                else
                    tempval += c.Value;
            }
            return tempval;
        }


        //returns true if the game continues if false game is stopp either because of win or lose
        public void CountPlayer()
        {
            if (Stats.YourCardScore > 21)
            {
                if (GetPlayerAlternate() < Stats.YourCardScore)
                {
                    Stats.YourCardScore = GetPlayerAlternate();
                } else
                {
                    // player loses
                    Stats.playerLost = true; // now dealer needs to have at least 17
                    CountDealer();
                    Stats.ChangeTurns();
                }
            } else if (Stats.YourCardScore == 21)
            {
                //do nothing
                Stats.ChangeTurns();
            } else if (Stats.YourCardScore < 21)
            {
                //ends and wait for dealer
                //do nothing
            }
        }

        public void CountDealer()
        {
            if (Stats.playerLost && Stats.DealerCardScore >= 17 && Stats.DealerCardScore <= 21) //if player has more than 21, dealer needs at least 17
            {
                Stats.DealerWins();
            } else if (Stats.DealerCardScore > Stats.YourCardScore && Stats.DealerCardScore <= 21) { // dealer needs less than 21 and more than player
                Stats.DealerWins();
            } else if (Stats.DealerCardScore > 21)
            {
                if (GetDealerAlternate() < Stats.DealerCardScore) //Aces conversion
                {
                    Stats.DealerCardScore = GetDealerAlternate();
                    CountDealer();
                } else
                {
                    Stats.CountWinner();
                }
            } else if (Stats.DealerCardScore == 21)
            {
                //do nothing
                Stats.CountWinner();
            }
        }

        public void InitialCount()
        {
            if (Stats.YourCardScore == 21 && Stats.DealerCardScore == 21) // both natural
            {
                Stats.Draw();
            } else if (Stats.YourCardScore == 21) //initial draw means 2 cards = natural blackjack
            {
                Stats.PlayerWins();
            } else if (Stats.DealerCardScore == 21)
            {
                Stats.DealerWins();
            }
        }

        public override void Draw(Graphics g)
        {
            //draw player cards
            for (int i = 0; i < playerCards.Count; i++)
            {
                Rectangle cardSpawn = new Rectangle(Constants.PLAYER_CARD_START_X + Constants.CARD_SPAWN_SPACE*i, Constants.PLAYER_CARD_START_Y, Constants.CARD_WIDTH, Constants.CARD_HEIGHT);

                Font font = new Font("Arial", 14);

                StringFormat format = new StringFormat();
                //format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                g.DrawRectangle(Pens.Black, cardSpawn);

                g.DrawString(playerCards[i].type.ToString(), font, Brushes.Black, cardSpawn, format);

                cardSpawn.Y += 40; //just adjust so the name is below the type. simple fix
                g.DrawString(playerCards[i].Name, font, Brushes.Black, cardSpawn, format);
            }

            //draw dealer cards
            for (int i = 0; i < dealerCards.Count; i++)
            {
                Rectangle cardSpawn = new Rectangle(Constants.DEALER_CARD_START_X + Constants.CARD_SPAWN_SPACE * i, Constants.DEALER_CARD_START_Y, Constants.CARD_WIDTH, Constants.CARD_HEIGHT);

                Font font = new Font("Arial", 14);

                StringFormat format = new StringFormat();
                //format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                g.DrawRectangle(Pens.Black, cardSpawn);

                g.DrawString(dealerCards[i].type.ToString(), font, Brushes.Black, cardSpawn, format);

                cardSpawn.Y += 40; //just adjust so the name is below the type. simple fix
                g.DrawString(dealerCards[i].Name, font, Brushes.Black, cardSpawn, format);
            }
        }
    }
}
