using System.Collections.Generic;
using System.Linq;

namespace BlackJackCardGame
{
    public class Hand
    {
        private List<Card> Cards = new List<Card>();

        public void AddToHand(Card card)
        {
            Cards.Add(card);
        }

        public string GetFormattedCards()
        {
            return string.Join(",", Cards.Select(GetFormattedCard));
        }

        public string GetFormattedTopCard()
        {
            return Cards.Select(GetFormattedCard).FirstOrDefault();
        }

        private string GetFormattedCard(Card card)
        {
            return $"{card.face} {card.suit}";
        }

        public int GetValue()
        {
            return Cards.OrderByDescending(c => c.face).Aggregate(0, CalculateValue);
        }

        private int CalculateValue(int sum, Card card)
        {
            var cardValue = 0;

            switch (card.face)
            {
                case Face.Jack:
                case Face.Queen:
                case Face.King:
                    cardValue = 10;
                    break;
                case Face.Two:
                case Face.Three:
                case Face.Four:
                case Face.Five:
                case Face.Six:
                case Face.Seven:
                case Face.Eight:
                case Face.Nine:
                case Face.Ten:
                    cardValue = (int)card.face;
                    break;
                case Face.Ace:
                    cardValue = CalculateAceValue(sum);
                    break;
                default:
                    cardValue = 0;
                    break;

            }

            return sum + cardValue;
        }

        private int CalculateAceValue(int sum)
        {
            var value = 0;

            if (sum + 11 > 21)
            {
                value = 1;
            }
            else
            {
                value = 11;
            }

            return value;
        }
    }
}
