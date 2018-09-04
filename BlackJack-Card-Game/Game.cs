using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public class Game
    {
        private Player _player { get; set; }
        private Dealer _dealer { get; set; }

        public Game()
        {
            var deck = new Deck();
            _player = new Player("Robert");
            _dealer = new Dealer("Dealer", deck);

            InitialDeal();
        }

        private void InitialDeal()
        {
            _player.AddCardToHand(_dealer.Hit());
            _dealer.AddCardToHand(_dealer.Hit());

            _player.AddCardToHand(_dealer.Hit());
            _dealer.AddCardToHand(_dealer.Hit());

            Console.WriteLine($"Dealer top card { _dealer.GetFormattedHand() }");
            Console.WriteLine($"Your hand: { _player.GetFormattedHand() }");
            Console.ReadLine();
        }
    }
}
