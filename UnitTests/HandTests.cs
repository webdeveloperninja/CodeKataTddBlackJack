using BlackJackCardGame;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class HandTests
    {
        [Fact]
        public void HandShouldAddToCards()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            sut.AddToHand(card);

            var expected = new List<Card> { card };

            Assert.Equal(sut.Cards, expected);
        }

        [Fact]
        public void HandShouldReturnFormattedHandIncludingFace()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantFace = Face.Eight.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.Formatted());
            Assert.DoesNotContain(nonExistantFace, sut.Formatted());
        }

        [Fact]
        public void HandShouldReturnFormattedHandIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.Formatted());
            Assert.DoesNotContain(nonExistantSuit, sut.Formatted());
        }
    }
}
