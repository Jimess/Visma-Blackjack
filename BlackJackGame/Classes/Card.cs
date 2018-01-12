using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Classes
{
    class Card
    {
        public enum Type { SPADES, HEARTS, CLUBS, DIAMONDS }
        public enum Cards { TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9, TEN = 10, JACK = 10, QUEEN = 10, KING = 10, ACE = 11 }

        public int Value;
        public int AlternativeValue;
        public string Name;
        public Type type;

        public Card(int value, string name, Type type)
        {
            Value = value;
            Name = name;
            this.type = type;
        }

        public static List<Card> GenerateAllCards()
        {
            List<Card> tempList = new List<Card>();

            foreach (Cards c in Enum.GetValues(typeof(Cards)))
            {
                foreach (Type t in Enum.GetValues(typeof(Type)))
                {
                    if (c == Cards.ACE)
                    {
                        Card tmp = new Card((int)c, c.ToString(), t);
                        tmp.AlternativeValue = 1;
                        tempList.Add(tmp);
                    } else
                    {
                        tempList.Add(new Card((int)c, c.ToString(), t));
                    }
                }
            }

            return tempList;
        }

        //public override void Draw(Graphics g)
        //{
        //    Font font = new Font("Arial", 14);

        //    StringFormat format = new StringFormat();
        //    //format.LineAlignment = StringAlignment.Center;
        //    format.Alignment = StringAlignment.Center;
            
        //    Rectangle cardBounds = new Rectangle(350, 350, 140, 200);

        //    g.DrawRectangle(Pens.Black, cardBounds);

        //    g.DrawString(type.ToString(), font, Brushes.Black, cardBounds, format);

        //    cardBounds.Y = 375; //just adjust so the name is below the type. simple fix
        //    g.DrawString(Name, font, Brushes.Black, cardBounds, format);
        //}
    }
}
