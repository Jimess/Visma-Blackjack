using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace BlackJackGame.Classes
{
    class Deck : Drawable
    {
        List<Card> cards = new List<Card>();

        public void Build()
        {
            cards = Card.GenerateAllCards();

            Random r = new Random();
            int rngseed = r.Next(1500);
            Shuffle(cards, rngseed);
            
        }

        public Card GetTopCard()
        {
            if (cards.Count > 0)
            {
                Card taken = cards[0];
                cards.RemoveAt(0);
                return taken;
            }

            Console.WriteLine("Deck Empty");
            return null;
            
        }

        public static void Shuffle<T>(IList<T> list, int seed)
        {
            var rng = new Random(seed);
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
