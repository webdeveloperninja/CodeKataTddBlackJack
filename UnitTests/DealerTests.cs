using BlackJackCardGame;
using Moq;
using System;
using Xunit;

namespace UnitTests
{
    public class DealerTests
    {
        [Fact]
        public void HitShouldCallDeckHit()
        {
            var deckMock = new Mock<IDeck>();
            var dealerName = "Robert";

            var sut = new Dealer(dealerName, deckMock.Object);

            sut.Hit();

            deckMock.Verify(x => x.Hit(), Times.Once);
        }
    }
}
