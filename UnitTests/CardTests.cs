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

        [Fact]
        public void IsAceShouldReturnTrueWhenFaceIsAce()
        {
            var face = Face.Ace;
            var card = new Card(Suit.Clubs, face);
       
            Assert.True(card.IsAce());
        }

        [Fact]
        public void IsAceShouldReturnFalseWhenFaceIsKing()
        {
            var face = Face.King;
            var card = new Card(Suit.Clubs, face);
       
            Assert.False(card.IsAce());
        }

        [Fact]
        public void IsRoyalCardShouldReturnTrueWhenFaceIsRoyalty()
        {
            var card = new Card(Suit.Clubs, Face.Jack);
            Assert.True(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Queen);
            Assert.True(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.King);
            Assert.True(card.IsRoyalCard());
        }

        [Fact]
        public void IsRoyalCardShouldReturnFalseWhenFaceIsNotRoyalty()
        {
            var card = new Card(Suit.Clubs, Face.Ace);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Ten);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Nine);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Eight);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Seven);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Six);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Five);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Four);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Three);
            Assert.False(card.IsRoyalCard());

            card = new Card(Suit.Clubs, Face.Two);
            Assert.False(card.IsRoyalCard());
        }
    }
}
