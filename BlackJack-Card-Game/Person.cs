using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{

    public enum Move
    {
        Hit,
        Stay
    }

    public abstract class Person
    {
        public string PlayerName { get; private set; }
        protected Hand _hand = new Hand();
 
        public Person(string name)
        {
            PlayerName = name;
        }

        public void AddCardToHand(Card card)
        {
            _hand.AddToHand(card);
        }

        public int GetHandValue()
        {
            return _hand.GetValue();
        }

        public virtual Move NextMove()
        {
            throw new NotImplementedException();
        }
    }
}
