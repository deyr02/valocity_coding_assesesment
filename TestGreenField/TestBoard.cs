using GreenField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestGreenField
{
    public class TestBoard
    {
        [Fact]
        public void PlayersCardShouldNotBeIdentical()
        {
            //Arrange
            Board board = new Board();
            //Act
            board.ShaffleCards();
            board.DistributeCards();

            //Assert
            Assert.NotEqual<List<Card>>(board.Players[0].Cards, board.Players[1].Cards);

        }
    }
}
