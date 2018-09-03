using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
    public enum Face
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suit suit { get; private set; }
        public Face face { get; private set; }

        public Card(Suit cardSuit, Face cardFace)
        {
            suit = cardSuit;
            face = cardFace;
        }
    }
}
