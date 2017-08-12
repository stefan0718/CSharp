using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _3_Card_Poker
{
    class Cards
    {
        // make a whole deck of cards that consists of 4 suits and 13 values
        public List<PokerCard> getADeckOfCards()
        {            
            List<PokerCard> pcDeck = new List<PokerCard>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    PokerCard pc = new PokerCard { suit = i, value = j };
                    pcDeck.Add(pc);
                }
            }
            return pcDeck;
        }

        // get all sets of 3 cards for all game players
        public List<ThreePokerCards> getSetsOfThreeCards()
        {
            List<ThreePokerCards> setsOfThreePokerCards = new List<ThreePokerCards>();
            Random r = new Random();
            // for i number of players
            for (int i = 0; i < 2; i++)
            {
                ThreePokerCards tpc = new ThreePokerCards();
                tpc.allCards = new List<PokerCard>();
                for (int j = 0; j < 3; j++)
                {
                    tpc.allCards.Add(getADeckOfCards()[r.Next(0, 52)]);
                }
                tpc.getEachCard();  // get each card details
                tpc.getHandRanks();  // get the hand rank of this tpc
                setsOfThreePokerCards.Add(tpc);
            }
            return setsOfThreePokerCards;
        }

        // parse a card suit and value to a string
        public string cardToString(PokerCard pc)
        {
            string suit = "";
            switch (pc.suit)
            {
                case 0:
                    suit = "♥";
                    break;
                case 1:
                    suit = "♠";
                    break;
                case 2:
                    suit = "♣";
                    break;
                case 3:
                    suit = "♦";
                    break;
            }
            switch (pc.value)
            {
                case 9:
                    return suit + "J";
                case 10:
                    return suit + "Q";
                case 11:
                    return suit + "K";
                case 12:
                    return suit + "A";                
            }
            return suit + (pc.value + 2);
        }

        // expose the player's own poker cards
        public void exposeThreeCards(ThreePokerCards tpc, List<Label> labels, List<Rectangle> rectangles)
        {
            for (int i = 0; i < 3; i++)
            {
                labels[i].Content = cardToString(tpc.allCards[i]);  // label 3 cards
                rectangles[i].Fill = Brushes.White;  // change card background to white
                if (tpc.allCards[i].suit == 0 || tpc.allCards[i].suit == 3)
                    labels[i].Foreground = Brushes.Red;  // for suits heart and diamond
                else
                    labels[i].Foreground = Brushes.Black;  // for suits spade and club
            }
        }

        // hide the player's own poker cards
        public void hideThreeCards(List<Label> labels, List<Rectangle> rectangles)
        {
            for (int i = 0; i < 3; i++)
            {
                labels[i].Content = "";  // empty labels
                rectangles[i].Fill = Brushes.DarkGray;  // change card background to dark gray
            }
        }

        public string showHandRank(ThreePokerCards tpc)
        {
            switch (tpc.handRanks)
            {
                case 0:
                    return "THREE OF A KIND";
                case 1:
                    return "STRAIGHT FLUSH";
                case 2:
                    return "FLUSH";
                case 3:
                    return "STRAIGHT";
                case 4:
                    return "PAIR";
                case 5:
                    return "HIGH CARD";
                case 6:
                    return "HIGH CARD 235";
            }
            return null;
        }

        // compare two hands. Return true if tpc1 wins
        /* RULES:
         * 
         * Three of a kind > Straight flush > Flush > Straight > Pair > High card > 235.
         * However, 235 > Three of a kind.
         * 
         * Note that tpc1 firstly has a showdown.
         * If two hands are equal, tpc1 loses as showdown.
         */
        public Boolean compareCards(ThreePokerCards tpc1, ThreePokerCards tpc2)
        {
            switch(tpc1.handRanks - tpc2.handRanks)
            {
                case -5: case -4: case -3: case -2: case -1: case 6:
                    return true;
                case 5: case 4: case 3: case 2: case 1: case -6:
                    return false;
                case 0:
                    if (tpc1.highestCard.value > tpc2.highestCard.value)
                        return true;
                    else if (tpc1.highestCard.value < tpc2.highestCard.value)
                        return false;
                    else
                    {
                        if (tpc1.middleCard.value > tpc2.middleCard.value)
                            return true;
                        else if (tpc1.middleCard.value < tpc2.middleCard.value)
                            return false;
                        else
                        {
                            if (tpc1.lowestCard.value > tpc2.lowestCard.value)
                                return true;
                            else
                                return false;
                        }
                    }
            }
            return false;
        }
    }
}
