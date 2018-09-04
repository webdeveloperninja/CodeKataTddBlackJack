using BlackJackCardGame;
using System;
using System.Linq;
using Xunit;

namespace UnitTests
{
    public class DeckTests
    {
        [Fact]
        public void HitShouldReturnCardAtIndexZero()
        {
            var numberOfCards = 52;
            var deck = new Deck();

            var copiedDeck = new Card[numberOfCards];

            Array.Copy(deck.Cards.ToArray(), copiedDeck, numberOfCards);

            var card = deck.Hit();

            Assert.Equal(copiedDeck.First(), card);
            Assert.Equal(deck.Cards.Count, --numberOfCards);
        }

        [Fact]
        public void ShouldInitialize52Cards()
        {
            var numberOfCards = 52;
            var deck = new Deck();

            Assert.Equal(deck.Cards.Count, numberOfCards);
        }
    }
}
