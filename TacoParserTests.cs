﻿using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert

            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", -84.60189)]
        [InlineData("34.170417,-84.782808,Taco Bell Cartersvill...", -84.782808)]

        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange

            TacoParser taco = new TacoParser();

            //Act

            double actual = taco.ParseLongitude(line);

            //Assert

            Assert.Equal(expected, actual);
        }


        //TODO: Create a test called ShouldParseLatitude

        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel...", 33.858498)]
        [InlineData("34.170417,-84.782808,Taco Bell Cartersvill...", 34.170417)]

        public void ShouldParseLatitude(string line, double expected)
        {
            TacoParser taco = new TacoParser();

            //Act

            double actual = taco.ParseLatitude(line);

            //Assert

            Assert.Equal(expected, actual);
        }
    }
}
