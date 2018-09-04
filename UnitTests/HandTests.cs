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

            Assert.Contains(card.face.ToString(), sut.GetFormattedCards());
            Assert.DoesNotContain(nonExistantFace, sut.GetFormattedCards());
        }

        [Fact]
        public void HandShouldReturnFormattedHandIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedCards());
            Assert.DoesNotContain(nonExistantSuit, sut.GetFormattedCards());
        }

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingFace()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantFace = Face.Eight.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedTopCard());
            Assert.DoesNotContain(nonExistantFace, sut.GetFormattedTopCard());
        }

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedTopCard());
            Assert.DoesNotContain(nonExistantSuit, sut.GetFormattedTopCard());
        }
    }
}
