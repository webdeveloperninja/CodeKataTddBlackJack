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

        [Fact]
        public void NextMoveStayGivenDeckValueEqualStayThreshold()
        {
            var deckMock = new Mock<IDeck>();

            deckMock.Setup(dM => dM.Hit()).Returns(new Card(Suit.Clubs, Face.Ace));
            var dealerName = "Robert";

            var sut = new Dealer(dealerName, deckMock.Object);
            sut.AddCardToHand(sut.Hit());

            var expectedValue = 11;
            var expectedNextMove = Move.Stay;

            Assert.Equal(sut.GetHandValue(), expectedValue);
            Assert.Equal(sut.NextMove(), expectedNextMove);
        }

        [Fact]
        public void NextMoveStayGivenDeckValueGreaterThenStayThreshold()
        {
            var deckMock = new Mock<IDeck>();

            deckMock.Setup(dM => dM.Hit()).Returns(new Card(Suit.Clubs, Face.Ace));
            var dealerName = "Robert";

            var sut = new Dealer(dealerName, deckMock.Object);
            sut.AddCardToHand(sut.Hit());

            deckMock.Setup(dM => dM.Hit()).Returns(new Card(Suit.Clubs, Face.Ten));
            sut.AddCardToHand(sut.Hit());

            var expectedValue = 21;
            var expectedNextMove = Move.Stay;

            Assert.Equal(sut.GetHandValue(), expectedValue);
            Assert.Equal(sut.NextMove(), expectedNextMove);
        }

        [Fact]
        public void NextMoveHitGivenDeckValueLessThanStayThreshold()
        {
            var deckMock = new Mock<IDeck>();

            deckMock.Setup(dM => dM.Hit()).Returns(new Card(Suit.Clubs, Face.Three));
            var dealerName = "Robert";

            var sut = new Dealer(dealerName, deckMock.Object);
            sut.AddCardToHand(sut.Hit());

            var expectedValue = 3;
            var expectedNextMove = Move.Hit;

            Assert.Equal(sut.GetHandValue(), expectedValue);
            Assert.Equal(sut.NextMove(), expectedNextMove);
        }
    }
}
