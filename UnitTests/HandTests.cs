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
            var hand = new Hand();
            hand.AddToHand(card);

            var expected = new List<Card> { card };

            Assert.Equal(hand.Cards, expected);
        }
    }
}
