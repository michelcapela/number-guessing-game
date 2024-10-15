
Console.WriteLine("You have to try to choose the number I chose, between 1 to 10!");



bool isCorrectGuess = false;

Random random = new Random();

while (!isCorrectGuess)
{

    int number = random.Next(1, 11);

    Console.WriteLine("Guess a number:");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess > number) { Console.WriteLine("Your guess is too right"); }
    else if (guess < number) { Console.WriteLine("Your guess is too low"); }
    else { Console.WriteLine("Correct!"); isCorrectGuess = true; }


}

Console.ReadKey();
