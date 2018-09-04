using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Hand
    {
        public List<Card> Cards { get; private set; } = new List<Card>();

        public void AddToHand(Card card)
        {
            Cards.Add(card);
        }
    }
}
