using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Classes
{
    class Constants
    {
        public static readonly int CANVAS_WIDHT = 1200;
        public static readonly int CANVAS_HEIGHT = 600;

        public static readonly int CARD_WIDTH = 120;
        public static readonly int CARD_HEIGHT = 160;
        public static readonly int CARD_OFFSETX = 50;
        public static readonly int CARD_OFFSETY = 50;
        public static readonly int CARD_SPAWN_SPACE = CARD_WIDTH + CARD_OFFSETX;

        //player card settings
        public static readonly int PLAYER_CARD_START_X = 0 + CARD_OFFSETX;
        public static readonly int PLAYER_CARD_START_Y = CANVAS_HEIGHT - CARD_HEIGHT - CARD_OFFSETY;

        //dealer card settings
        public static readonly int DEALER_CARD_START_X = 0 + CARD_OFFSETX;
        public static readonly int DEALER_CARD_START_Y = 0 + CARD_OFFSETY;
    }
}
