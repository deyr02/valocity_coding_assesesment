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

        [Theory]
        [InlineData("David")]
        [InlineData("Smith")]
        public void ShouldInitializeDOBPropertiesThroudhContructorOne(string name)
        {
            //Arrange
            People people = new People(name);

            //Act
            DateTimeOffset _dob = people.DOB;
            DateTimeOffset _exptedDOB = DateTimeOffset.UtcNow.AddYears(-15).Date;
            //assert

            Assert.Equal(_exptedDOB, _dob);
        }


        [Theory]
        [InlineData("Bob", "1/08/1988 11:01:37 pm +00:00", "Bob")]
        public void ShoudInitializeNamePropertiesThroughConstructorTwo(string name, string dob, string expectedName)
        {
            //Arrange
            People people = new People(name, Convert.ToDateTime(dob));
            //Act 
            var _name = people.Name;
            //Assert
            Assert.Equal(expectedName, _name);
        }


        [Theory]
        [InlineData("Tom", "1/08/1988 11:01:37 pm +00:00", "1/08/1988 11:01:37 pm +00:00")]
        public void ShoudInitializeDOBPropertiesThroughConstructorTwo(string name, string dob, string expectedDOB)
        {
            //Arrange
            People people = new People(name, Convert.ToDateTime(dob));
            //Act 
            var _dob = people.DOB;
            //Assert
            Assert.Equal(Convert.ToDateTime(expectedDOB), _dob);

        }
    }
}
