using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackCardGame
{
    public interface IDeck
    {
        Queue<Card> Cards { get; }
        Card Hit();
    }
}
