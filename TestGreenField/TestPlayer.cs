using GreenField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestGreenField
{
    public class TestPlayer
    {
        [Theory]
        [InlineData("Bob", "Bob")]
        public void ShouldInitializePlayerName(string playerName, string exptectedName)
        {
            //Arrange
            Player player = new Player(playerName);

            //Act
            string _name = player.Name;
            //Assert
            Assert.Equal(exptectedName, _name);
        }

        [Theory]
        [InlineData("Bob", "Heart", "A")]
        public void ShouldAddNewCardToUser(string playerName, string suiteName, string cardName)
        {
            //Arrange
            Player player = new Player(playerName);

            //Act
            Card card = new Card(suiteName, cardName);
            player.AddCard(card);
            //Assert
            Assert.Equal<Card>(card, player.Cards[player.Cards.Count -1]);
        }
    }
}
