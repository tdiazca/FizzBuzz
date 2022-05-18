﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public delegate void PopulateMyListOfNumbersDelegate(object sender, EventArgs args); //anounce that an action has been done: MyListOfNumbersPopulated

    public class FizzBuzzGame
    {
        // constructor method
        public FizzBuzzGame()
        {
            NumberEntered = 0;                  // initializing fields of the class
            MyListOfNumbers = new List<int>();
        }

        // Greet user
        public void GreetUser()
        {
            Console.WriteLine("Welcome to FizzBuzz!\nUsernames must be between 2 and 10 characters long.");
        }
        //Ask user for name
        public void AskUserForName()
        {
            Console.WriteLine("Please enter your username:");
            var username = Console.ReadLine();
            if(username.Length >= 2 && username.Length <= 10)
            {
                Console.WriteLine($"Welcome {username}!");
            }
            else
            {
                throw new ArgumentOutOfRangeException($"{nameof(username)} does not have the right lenght.");
            }

        }

        //Ask user for age
        public void AskUserForAge()
        {
            Console.WriteLine("You must be between 12 and 18 to play this game.");
            Console.WriteLine("Please, enter your age:");
            var age = int.Parse(Console.ReadLine());
            if (age >= 12 && age <= 18)
            {
                Console.WriteLine("You may play FizzBuzz.");
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Sorry, users of your {nameof(age)} are not allowed to play FizzBuzz.");
                //for now it just quits the whole game!! No time for user to read message. TODO
            }
        }

        //Ask user to input a positive number between 1 and 1000 and store this value to allow testing
        public int AskUserForNumber()
        {
            Console.WriteLine("Please, enter a positive whole number between 1 and 1000.");
            var inputnumber = int.Parse(Console.ReadLine());
            return inputnumber;
        }

        //Ask user to input a positive number between 1 and 1000
        public void AssignInputNumberToNumberEntered(int inputnumber)
        {
            if (inputnumber >= 1 && inputnumber <= 1000)
            {
                NumberEntered = inputnumber;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Invalid {nameof(inputnumber)}");
            }
        }

        ////Ask user to input a positive number between 1 and 1000
        //public void AskUserForNumber()
        //{
        //    Console.WriteLine("Please, enter a positive whole number between 1 and 1000.");
        //    var number = int.Parse(Console.ReadLine());
        //    if (number >= 1 && number <= 1000)
        //    {
        //        NumberEntered = number;
        //    }
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException($"Invalid {nameof(number)}");
        //    }
        //}

        //Obtain range of numbers between input number and number 1
        public IEnumerable<int> GetNumberRange()
        {
            var myrange = Enumerable.Range(1, NumberEntered);
            return myrange;
        }

        //Populate MyListOfNumbers with numbers from the range generated by GetNumberRange()
        public void PopulateMyListOfNumbers(IEnumerable<int> myrange)
        {
            foreach (int value in myrange)
            {
                MyListOfNumbers.Add(value);
            }

            if(MyListOfNumbersPopulated != null) // raising an event to say that this has been done (MyListOfNumbers has been populated)
            {
                MyListOfNumbersPopulated(this, new EventArgs()); // event
            }
        }

        //Play again or stop the game
        public string PlayAgainOrStop()
        {
            MyListOfNumbers = new List<int>(); // reset MyListOfNumbers to an empty after game has been played.
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Please, enter 'yes' to start a new game or 'no' to exit the program.");
            var input = Console.ReadLine();
            return input;
        }

        //Say goodbye
        public void SayGoodbye()
        {
            Console.WriteLine("Thanks for playing FizzBuzz.");
            Console.WriteLine("Goodbye!");
        }

        public int NumberEntered // is the property that access the field NumberEntered
        {
            get; set;
        }

        public List<int> MyListOfNumbers // does the same but for myListOfNumbers, which is a pirvate field. (better just write it as above)
        {
            get
            {
                return myListOfNumbers;
            }
            set
            {
                myListOfNumbers = value;
            }
        }

        public event PopulateMyListOfNumbersDelegate MyListOfNumbersPopulated;  // delegate field of the class

        // class fields  // PRIVATE members of the class are put typically at the end of the class

        private List<int> myListOfNumbers; // better keep it private! a form of encapsulation
    }
}


// Repeat but now, if day today is Wednesday:
//   same but printing wizz and wuzz instead of fizz fuzz



//1) Ask user for input = Please, type a positive number between 1 and 1000

// var numbers = new int[3] {12.3, 4,5, 6,7};

//        var numbers = new[] {}; // Range(0,number)

//       List<int> values = new List<int>();