using System;
using Xunit;
using System.Collections; // so we can add an ArrayList collection

// both FizzBuzz and FizzBuzz.Test are underneath same namespace (fizzbuzz)

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {

        // Test 1 - FizzBuzz generates correct range of numbers from user input and adding this numbers to the class field myListOfNumbers
        //        - GameResult generates the expected outcome (will be printed by Program)
        //
        // Test 2 - Exceptions are handleled as expected

        // TODO - try different testcases [TestCase]

        [Fact]     // attribute to indicate this is a test - tell test runner to run it
        public void FizzBuzzGeneratesCorrectListOfNumbersBetweenUserInputNumberAnd1AndExpectedGameResult()
        {
            // arrange
            var newgame = new FizzBuzzGame();
            newgame.NumberEntered = 15;         //mocking user input [TestCase][NumberEntered = 15]
            var gameresult = new GameResult();
            var expectedresult = new ArrayList() { 1, 2, "fizz", 4, "fuzz", "fizz", 7, 8, "fizz", "fuzz", 11, "fizz", 13, 14, "fizz fuzz" };

            // act
            var myrange = newgame.GetNumberRange(); // expected result newgame.MyListOfValues = {1,2,...15}
            newgame.PopulateMyListOfNumbers(myrange);
            var mygameresult = gameresult.StoreGameResult(newgame);

            // assert
            Assert.Equal(15, newgame.MyListOfNumbers.Count);
            Assert.Equal(1, newgame.MyListOfNumbers[0]);
            Assert.Equal(15, newgame.MyListOfNumbers[14]);
            Assert.Equal(expectedresult, mygameresult);
            //
        }

        [Fact]
        public void IfInvalidNumberIsProvidedAnArgumentOutOfRangeExceptionIsThrown()
        {
            // arrange
            var newgame = new FizzBuzzGame();

            // act
            var inputnumber = 2000;

            // assert
            Assert.Throws<ArgumentOutOfRangeException>(() => newgame.AssignInputNumberToNumberEntered(inputnumber));
        }
    }
}
