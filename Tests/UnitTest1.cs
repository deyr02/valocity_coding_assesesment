using System;
using CodingAssessment.Refactor;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class TestPeopleClassInitialization
    {
        [Theory]
        [InlineData("Rajib", "Rajib")]
        public void ShouldInitializeNamePropertiesThroughConstructorOne(string name, string expectedName)
        {
            //Arrange
            People people = new People(name);
            //Act 
            var _name = people.Name;
            //Assert
            Assert.Equal(expectedName, _name);

        }
    }
}
