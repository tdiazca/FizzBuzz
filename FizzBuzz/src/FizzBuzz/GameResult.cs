using System;
using System.Collections;  // so we can add an ArrayList collection

namespace FizzBuzz
{
    public class GameResult
    {

        //Loop through each number and print string accordingly
        public void PrintGameResult(FizzBuzzGame newgame)
        {
            Console.WriteLine("This is your result:\n");
            foreach (var number in newgame.MyListOfNumbers)
            // foreach (var number in Enumerable.Range(0, number).Where(number => number % 3 == 0 and number % 5 == 0)
            //{ Console.WriteLine("fizz buzz"); }     
            {
                if ((number % 3) == 0 && (number % 5) == 0)
                {
                    Console.WriteLine("fizz fuzz");
                }
                else if ((number % 3) == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if ((number % 5) == 0)
                {
                    Console.WriteLine("fuzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }

        public ArrayList StoreGameResult(FizzBuzzGame newgame) // this method allows testing FizzBuzz produces correct result
        {
            var myresult = new ArrayList();     
            foreach (var number in newgame.MyListOfNumbers)
            {
                if ((number % 3) == 0 && (number % 5) == 0)
                {
                    myresult.Add("fizz fuzz");
                }
                else if ((number % 3) == 0)
                {
                    myresult.Add("fizz");
                }
                else if ((number % 5) == 0)
                {
                    myresult.Add("fuzz");
                }
                else
                {
                    myresult.Add(number);
                }
            }
            return myresult;
        }

        //Logic ammended for Wednesday day case: if day of the week is Wednesday, else, call previous method
        public void PrintGameResulFortWednesday(FizzBuzzGame newgame)
        {
            foreach (var number in newgame.MyListOfNumbers)
            {
                if ((number % 3) == 0 && (number % 5) == 0)
                {
                    Console.WriteLine("wizz wuzz");
                }
                else if ((number % 3) == 0)
                {
                    Console.WriteLine("wizz");
                }
                else if ((number % 5) == 0)
                {
                    Console.WriteLine("wuzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
