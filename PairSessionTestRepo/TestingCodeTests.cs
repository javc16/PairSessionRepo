using PairSessionRepo;
using System;
using Xunit;

namespace PairSessionTestRepo
{
    public class TestingCodeTests
    {
        [Fact]
        public void Given_The_User_Input_Is_Empty_Should_Return_Zero()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 0;
            // Act
            var result = calc.Sum();
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Given_The_User_Input_Is_One_Number_Should_Return_Same_Number()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 3;
            // Act
            var result = calc.Sum("3");
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Given_The_User_Input_Are_Two_Numbers_Should_Return_The_Sum_Of_Those_Numbers()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 3;
            // Act
            var result = calc.Sum("1,2");
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Given_The_User_Input_Is_An_Unknown_Amount_Of_Numbers_Should_Return_The_Sum_Of_Those_Numbers()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 6;
            // Act
            var result = calc.Sum("1,2,3");
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Given_The_User_Input_Is_Multiple_Numbers_With_New_Line_And_Coma_Delimiters_Should_Return_The_Sum_Of_Those_Numbers()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 6;
            // Act
            var result = calc.Sum("1\n2,3");
            // Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Given_The_User_Input_Is_Multiple_Numbers_A_Custo_Delimiete_Should_Return_The_Sum_Of_Those_Numbers()
        {
            // Arrange
            var calc = new Calculator();
            var expect = 3;
            // Act
            var result = calc.Sum("//;\n1;2");
            // Assert
            Assert.Equal(expect, result);
        }
    }
}
