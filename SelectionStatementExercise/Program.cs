namespace SelectionStatementExercise
{
    public class Program
    {

        static void GuessingGame()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Let's play a guessing game. Guess any number between 1 and 1000.");
            while(true)
            {

                 var userInput = int.Parse(Console.ReadLine());

                if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high. Guess again.");
                }

                else if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low. Guess again.");

                }

                else
                {
                    Console.WriteLine("You guessed the right number! Congratulations!");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            GuessingGame();

        }
    }
}
