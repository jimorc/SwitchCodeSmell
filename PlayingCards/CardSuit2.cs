using System;

namespace PlayingCards
{
    public abstract class CardSuit2
    {
        public enum SuitNames
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        protected CardSuit2()
        { }

        public static CardSuit2 MakeCardSuit(SuitNames suit)
        {
            switch (suit)
            {
                case SuitNames.Clubs:
                    return new Clubs();
                case SuitNames.Diamonds:
                    return new Diamonds();
                case SuitNames.Hearts:
                    return new Hearts();
                case SuitNames.Spades:
                    return new Spades();
                default:
                    throw new ArgumentOutOfRangeException("CardSuit2 constructor", "The suit value is not valid.");
            }
        }

        public abstract override string ToString();
    }

    internal class Clubs: CardSuit2
    {
        public Clubs() { }
        public override string ToString()
        {
            return "♣";
        }
    }

    internal class Diamonds : CardSuit2
    {
        public Diamonds() { }
        public override string ToString()
        {
            return "♦";
        }
    }

    internal class Hearts : CardSuit2
    {
        public Hearts() { }
        public override string ToString()
        {
            return "♥";
        }
    }

    internal class Spades : CardSuit2
    {
        public Spades() { }
        public override string ToString()
        {
            return "♠";
        }
    }
}