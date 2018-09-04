using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Dealer : Person
    {
        private IDeck _deck;

        public Dealer(string name, IDeck deck) : base(name)
        {
            _deck = deck;
        }

        public Card Hit()
        {
            return _deck.Hit();
        }

        public string GetFormattedHand()
        {
            return this._hand.GetFormattedTopCard();
        }
    }
}
