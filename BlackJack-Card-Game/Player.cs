namespace BlackJackCardGame
{
    public class Player : Person
    {
        public Player(string name) : base(name) { }

        public string GetFormattedHand()
        {
            return this._hand.GetFormattedCards();
        }
    }
}
