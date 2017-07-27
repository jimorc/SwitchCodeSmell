using System;
using Xunit;
using PlayingCards;

namespace xUnitTests
{
    public class CardSuit3Tests
    {
        [Theory]
        [InlineData(CardSuit3.SuitNames.Clubs, "♣")]
        [InlineData(CardSuit3.SuitNames.Diamonds, "♦")]
        [InlineData(CardSuit3.SuitNames.Hearts, "♥")]
        [InlineData(CardSuit3.SuitNames.Spades, "♠")]
        public void CardSuit3ToStringTest(CardSuit3.SuitNames suit, string suitString)
        {
            var cardSuit = new CardSuit3(suit);

            var card = cardSuit.ToString();

            Assert.Equal(suitString, card);
        }

        [Fact]
        public void CardSuit3ConstructorInvalidValueTest()
        {
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(()
                => new CardSuit3((CardSuit3.SuitNames)(-1)));

            bool invalidSuit = ex.Message.Contains("The suit value is not valid.");

            Assert.True(invalidSuit);
        }
    }
}