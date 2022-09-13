using GreenField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestGreenField
{
    public class TestSuite
    {
        [Theory]
        [InlineData("Heart", "Heart")]
        [InlineData("Diamond", "Diamond")]
        [InlineData("Spade", "Spade")]
        [InlineData("Club", "Club")]
        public void ShouldInitializeSuiteName(string suiteName, string expectedSuiteName)
        {
            //Arange
            Suite suite = new Suite(suiteName);
            //Act
            string _suiteName = suite.Name;
            //Assert
            Assert.Equal(expectedSuiteName, _suiteName);
            
        }

        [Theory]
        [InlineData("Heart")]
        public void SuiteItemsShouldBeCreated(string suiteName)
        {
            //Arange
            Suite suite = new Suite(suiteName);
            //Act
            var cards = suite.Cards;
            //Assert
            Assert.NotEmpty(cards);
        }

        [Theory]
        [InlineData("Heart", "A")]
        [InlineData("Diamond", "K")]
        public void SuiteItemsShouldContainsCard(string suiteName, string cardName)
        {
            //Arange
            Suite suite = new(suiteName);
            //Act
            var cards = suite.Cards;
            var card = new Card(suiteName, cardName);
            //Assert
            Assert.Contains<Card>(cards.FirstOrDefault(x=> x.CardName== cardName), cards);
            ;
        }
    }
}
