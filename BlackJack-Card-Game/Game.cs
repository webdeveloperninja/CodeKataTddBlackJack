using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Game
    {
        private Deck _deck { get; set; }
        private Player _player { get; set; }
        private Player _dealer { get; set; }

        public Game()
        {
            _deck = new Deck();
            _player = new Player("Robert");
            _dealer = new Player("Dealer");

            InitialDeal();
        }

        private void InitialDeal()
        {
            _player.AddCardToHand(_deck.Hit());
            _dealer.AddCardToHand(_deck.Hit());

            _player.AddCardToHand(_deck.Hit());
            _dealer.AddCardToHand(_deck.Hit());
        }
    }
}
