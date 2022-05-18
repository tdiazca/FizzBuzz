FIZZBUZZ CONSOLE APPLICATION

I have developed this application using the following source as inspiration: "Using FizzBuzz to Find Developers who Grok Coding" http://tickletux.wordpress.com/2007/01/24/using-fizzbuzz-to-find-developers-who-grok-coding/

The application has been developed in C# coding language and .NET framework on MVS 2019.

This FizzBuzz console application has the following functionality:
	- Greets the user.
	- Asks user to input their user name (must be min two characters long).
	- Asks user for their age (users must be between 12 and 18 years to play).
	- Asks user for a number. This must be a positive number between 1 and 1000.
	- Prints out in a vertical list all, all of the values between 1 and the entered value.
		Where the number is divisible by 3, you should instead print ‘fizz’.
		Where the number is divisible by 5, you should instead print 'buzz'.
		Where the number is divisible by 3 AND 5, you should instead print ‘fizz buzz’.
	- Asks the user if they want to play again.
	- Depending on the users response, the program says goodbye and the application stops running or it runs again.
	
Validation has been added to ensure that: the entered username is at least two characters long, the user is between 12 and 18 years old, the entered value is an integer between 1 and 1000 and exceptions are handled correctly.

Tests have been written in order to ensure that:
	- The application follows this logic and generates results that are correct.
	- When the value entered is not within the valid range, the corresponding exception is thrown.

Instructions for running the application:
	- Start MVS
	- Open the 'fizzbuzz' solution.
	- Set up 'Fizzbuzz' (in src) as the Startup Project.
	- Make sure 'Debug' is selected as the Solution Configuration in MVS.
	- Click 'Start' to start running the application.
	- Follow the instructions that appear on the console.

