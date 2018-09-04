using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackCardGame
{
    public class Deck : IDeck
    {
        public Queue<Card> Cards { get; private set; }

        public Deck() {
            CreateDeck();
        }

        public Card Hit()
        {
            return Cards.Dequeue();
        }

        private List<Card> ShuffleDeck(List<Card> cards)
        {
            return cards.OrderBy(c => Guid.NewGuid()).ToList();
        }

        private void CreateDeck()
        {
            var cards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    var card = new Card(suit, face);
                    cards.Add(card);
                }
            }

            var shuffledCards = ShuffleDeck(cards);
 
            Cards = new Queue<Card>(shuffledCards);
        }
    }
}
