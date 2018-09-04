using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public Hand hand { get; private set; } = new Hand();

        public Player(string name)
        {
            PlayerName = name;
        }

        public void AddCardToHand(Card card)
        {
            hand.AddToHand(card);
        }
    }
}
