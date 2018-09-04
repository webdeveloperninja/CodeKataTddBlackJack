using BlackJackCardGame;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class HandTests
    {
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

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingFace()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantFace = Face.Eight.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetTopCard());
            Assert.DoesNotContain(nonExistantFace, sut.GetTopCard());
        }

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetTopCard());
            Assert.DoesNotContain(nonExistantSuit, sut.GetTopCard());
        }
    }
}
