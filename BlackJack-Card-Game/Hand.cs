using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackCardGame
{
    public class Hand
    {
        private List<Card> Cards = new List<Card>();

        public void AddToHand(Card card)
        {
            Cards.Add(card);
        }

        public string Formatted()
        {
            return string.Join(",", Cards.Select(GetFormattedCard));
        }

        public string GetTopCard()
        {
            return Cards.Select(GetFormattedCard).FirstOrDefault();
        }

        private string GetFormattedCard(Card card)
        {
            return $"{card.face} {card.suit}";
        }
    }
}
