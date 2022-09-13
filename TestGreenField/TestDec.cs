using GreenField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestGreenField
{
    public class TestDec
    {
        [Fact]
        public void ShoudInitialiizeFourSuitesOfCards()
        {
            //Arrange
            Deck deck = new Deck();

            //Act
            List<Card> cards_repo = deck.Repository;
            //Assert

            Assert.NotEmpty(cards_repo);
        }

        [Fact]
        public void ShouldShuffleTheCards()
        {
            //Arrange
            Deck deck = new Deck();

            //Act
            List<Card> cards_repo = new List<Card>();
            cards_repo.AddRange(deck.Repository);

           var shuffledCards = deck.Shuffle();

            //Assert

            Assert.NotEqual<List<Card>>(cards_repo, shuffledCards);
        }

    }
}
