using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz  
{
    class Program // defines a type
    {
        static void Main() // program entered at Main() method
        {
            var newgame = new FizzBuzzGame();

            newgame.MyListOfNumbersPopulated += OnMyListOfNumbersPopulated;     // event is an special type of delegate
                // handle event (subscribe to an event and listen to it, then handle it)

            newgame.GreetUser();

            try
            {
                newgame.AskUserForName();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                newgame.AskUserForName();
            }

            try
            {
                newgame.AskUserForAge();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "Good bye");
                throw; // TODO - would be better to stop the program on another way - user doesnt get time to read the message when it stops.
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                newgame.AskUserForAge();
            }

            void RunMe()
            {
                var x = true;
                while (x == true)
                {
                    try
                    {
                        var inputnumber = newgame.AskUserForNumber();          // ask user for input number
                        newgame.AssignInputNumberToNumberEntered(inputnumber); // set it as value for NumberEntered field of the class
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                        var inputnumber = newgame.AskUserForNumber();
                        newgame.AssignInputNumberToNumberEntered(inputnumber);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        var inputnumber = newgame.AskUserForNumber();
                        newgame.AssignInputNumberToNumberEntered(inputnumber);
                    }
                    finally
                    {
                        Console.WriteLine("**************");    // always executes. Useful for always closing a file, for example, regardless of exceptions etc
                    }

                    var myrange = newgame.GetNumberRange(); // obtains range of numbers and returns it as a list of int
                    newgame.PopulateMyListOfNumbers(myrange); // adds numbers to list of doubles field of the class MyListOfNumbers
                    var printresult = new GameResult();
                    printresult.PrintGameResult(newgame);

                    var y = true;
                    while (y == true)
                    {
                        try
                        {
                            var input = newgame.PlayAgainOrStop();

                            if (input == "no")
                            {
                                newgame.SayGoodbye();
                                y = false;
                                x = false;
                                //break;  // skips rest of iteration and goes back to the begining. Shouldnt need it here anyway.
                            }
                            else if (input == "yes")
                            {
                                y = false;
                            }
                            else
                            {
                                throw new ArgumentException($"Invalid {nameof(input)}");
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message); // catches nearest exception and goes back to while loop cauxe x == true still.
                        }
                    }
                }
            }

            RunMe();

        }
        static void OnMyListOfNumbersPopulated(object sender, EventArgs e)  // this is an event handler (code that will react to an event)
        {
            Console.WriteLine("MyListOFNumbers was populated");
        }
    }
}
