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
    }
}
