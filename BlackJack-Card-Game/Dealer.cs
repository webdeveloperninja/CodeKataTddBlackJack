using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Dealer : Player
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
    }
}
