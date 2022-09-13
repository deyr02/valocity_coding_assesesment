using System;
using FluentAssertions;
using GreenField;
using Xunit;


namespace TestGreenField
{
    public class TestCard
    {
        [Theory]
        [InlineData("Heart", "A", "Heart")]
        public void ShouldInatilizeSuiteName(string suiteName, string cardName, string expectedSuiteName)
        {
            //Arange
            Card card = new Card(suiteName, cardName);
            //Act
            string _suiteName = card.SuiteName;
            //Assert
            Assert.Equal(expectedSuiteName, _suiteName);

        }
        
        
        [Theory]
        [InlineData("Heart", "A", "A")]
        public void ShouldInatilizeCardName(string suiteName, string cardName, string expectName)
        {
            //Arange
            Card card = new Card(suiteName, cardName);
            //Act
            string _cardName = card.CardName;
            //Assert
            Assert.Equal(expectName, _cardName);

        }
    }
}
