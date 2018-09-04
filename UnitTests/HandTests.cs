using BlackJackCardGame;
using Xunit;

namespace UnitTests
{
    public class HandTests
    {
        [Fact]
        public void HandShouldReturnFormattedHandIncludingFace()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantFace = Face.Eight.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedCards());
            Assert.DoesNotContain(nonExistantFace, sut.GetFormattedCards());
        }

        [Fact]
        public void HandShouldReturnFormattedHandIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedCards());
            Assert.DoesNotContain(nonExistantSuit, sut.GetFormattedCards());
        }

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingFace()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantFace = Face.Eight.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedTopCard());
            Assert.DoesNotContain(nonExistantFace, sut.GetFormattedTopCard());
        }

        [Fact]
        public void HandShouldReturnFormattedTopCardIncludingSuit()
        {
            var card = new Card(Suit.Clubs, Face.Five);
            var sut = new Hand();
            var nonExistantSuit = Suit.Diamonds.ToString();

            sut.AddToHand(card);

            Assert.Contains(card.face.ToString(), sut.GetFormattedTopCard());
            Assert.DoesNotContain(nonExistantSuit, sut.GetFormattedTopCard());
        }

        [Fact]
        public void HandValueShouldReturn11GivenAce()
        {
            var card = new Card(Suit.Clubs, Face.Ace);
            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 11;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn21GivenAceAndKing()
        {
            var card1 = new Card(Suit.Clubs, Face.Ace);
            var card2 = new Card(Suit.Clubs, Face.King);
            var sut = new Hand();

            sut.AddToHand(card1);
            sut.AddToHand(card2);

            var expected = 21;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn2Given2()
        {
            var card = new Card(Suit.Clubs, Face.Two);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 2;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn3Given3()
        {
            var card = new Card(Suit.Clubs, Face.Three);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 3;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn4Given4()
        {
            var card = new Card(Suit.Clubs, Face.Four);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 4;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn5Given5()
        {
            var card = new Card(Suit.Clubs, Face.Five);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 5;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn6Given6()
        {
            var card = new Card(Suit.Clubs, Face.Six);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 6;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn7Given7()
        {
            var card = new Card(Suit.Clubs, Face.Seven);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 7;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn8Given8()
        {
            var card = new Card(Suit.Clubs, Face.Eight);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 8;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn9Given9()
        {
            var card = new Card(Suit.Clubs, Face.Nine);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 9;

            Assert.Equal(sut.GetValue(), expected);
        }

        [Fact]
        public void HandValueShouldReturn10Given10()
        {
            var card = new Card(Suit.Clubs, Face.Ten);

            var sut = new Hand();

            sut.AddToHand(card);

            var expected = 10;

            Assert.Equal(sut.GetValue(), expected);
        }
    }
}
