using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Card_Poker
{
    class PokerCard
    {
        /*
        private int suit, value;

        public PokerCard(int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public int getValue() { return value; }
        public void setValue(int value) { this.value = value; }
        public int getSuit() { return suit; }
        public void setSuit(int suit) { this.suit = suit; }*/
        public int suit { set; get; }
        public int value { set; get; }
    }

    class ThreePokerCards
    {
        public int handRanks { set; get; }
        public List<PokerCard> allCards{ set; get; }
        public PokerCard lowestCard { set; get; }
        public PokerCard middleCard { set; get; }
        public PokerCard highestCard { set; get; }

        // get each card with the highest, middle and lowest value
        public void getEachCard()
        {
            try
            {
                lowestCard = new PokerCard();
                highestCard = new PokerCard();
                middleCard = new PokerCard();
                int lowestValue = allCards.Min(cp => cp.value);
                int highestValue = allCards.Max(cp => cp.value);
                lowestCard = allCards.Find(cp => cp.value == lowestValue);
                highestCard = allCards.Find(cp => cp.value == highestValue);
                middleCard = allCards.Find(cp => cp != highestCard && cp != lowestCard);
                
            }
            catch (ArgumentNullException ane) { }
        }

        public void getHandRanks()
        {
            if (allCards.Count == 3)
                handRanks = 5;  // 5 represents High card
                if (lowestCard.value == highestCard.value)
                    handRanks = 0;  // 0 represents Three of a kind
                else if (lowestCard.value == middleCard.value || middleCard.value == highestCard.value)
                    handRanks = 4;  // 4 represents Pair
                else if (highestCard.value - lowestCard.value == 2
                    || (highestCard.value == 12 && middleCard.value == 1 && lowestCard.value == 0))  // A 2 3
                {
                    if (highestCard.suit == middleCard.suit && middleCard.suit == lowestCard.suit)
                        handRanks = 1;  // 1 represents Straight flush
                    handRanks = 3;  // 3 represents Straight
                }
                else if (highestCard.suit == middleCard.suit && middleCard.suit == lowestCard.suit)
                    handRanks = 2;  // 2 represents Flush
                else if (highestCard.value == 3 && middleCard.value == 1 && lowestCard.value == 0)
                    handRanks = 6;  // 6 represents 235
        }
    }
}
