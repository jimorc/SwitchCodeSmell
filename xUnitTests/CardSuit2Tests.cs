using System;
using Xunit;
using PlayingCards;

namespace xUnitTests
{
    public class CardSuit2Tests
    {
        [Theory]
        [InlineData(CardSuit2.SuitNames.Clubs, "♣")]
        [InlineData(CardSuit2.SuitNames.Diamonds, "♦")]
        [InlineData(CardSuit2.SuitNames.Hearts, "♥")]
        [InlineData(CardSuit2.SuitNames.Spades, "♠")]
        public void CardSuit2ToStringTest(CardSuit2.SuitNames suit, string suitString)
        {
            var cardSuit = CardSuit2.MakeCardSuit(suit);

            var card = cardSuit.ToString();

            Assert.Equal(suitString, card);
        }

        [Fact]
        public void CardSuit2MakeCardSuitInvalidValueTest()
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(()
                => CardSuit2.MakeCardSuit((CardSuit2.SuitNames)(-1)));

            bool invalidSuit = ex.Message.Contains("The suit value is not valid.");

            Assert.True(invalidSuit);
        }
    }
}