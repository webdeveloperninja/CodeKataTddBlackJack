using System.Collections.Generic;

namespace BlackJackCardGame
{
    public interface IDeck
    {
        Queue<Card> Cards { get; }
        Card Hit();
    }
}
