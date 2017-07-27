using System;

namespace PlayingCards
{
    public class CardSuit3
    {
        public enum SuitNames
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public CardSuit3(SuitNames suit)
        {
            switch (suit)
            {
                case SuitNames.Clubs:
                    suitString = "♣";
                    break;
                case SuitNames.Diamonds:
                    suitString = "♦";
                    break;
                case SuitNames.Hearts:
                    suitString = "♥";
                    break;
                case SuitNames.Spades:
                    suitString = "♠";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("CardSuit3 constructor", "The suit value is not valid.");
            }
        }

        public override string ToString()
        {
            return suitString;
        }

        private readonly string suitString;
    }

}