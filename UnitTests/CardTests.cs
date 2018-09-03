using BlackJackCardGame;
using System;
using Xunit;

namespace UnitTests
{
    public class CardTests
    {
        [Fact]
        public void CardShouldSetSuit()
        {
            var suit = Suit.Clubs;
            var card = new Card(suit, Face.Five);
            var expected = suit;

            Assert.Equal(card.suit, expected);
        }

        [Fact]
        public void CardShouldSetFace()
        {
            var face = Face.Ace;
            var card = new Card(Suit.Clubs, face);
            var expected = face;

            Assert.Equal(card.face, expected);
        }
    }
}
