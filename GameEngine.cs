using Math_Game.Models;

namespace Math_Game
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int sum = firstNumber + secondNumber;
                Console.WriteLine($"What is {firstNumber} + {secondNumber}?");

                var userChoice = Console.ReadLine();

                userChoice = Helpers.ValidateResult(userChoice);

                

                if (int.Parse(userChoice) == sum)
                {
                    Helpers.CorrectAnswer();
                    ++score;
                    Console.WriteLine($"Current score: {score}");

                }
                else
                {
                    Helpers.IncorrectAnswer();
                }
                Helpers.GameOver(i, score);
            }

            Helpers.AddToHistory(score, GameType.Addition);




        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int difference = firstNumber - secondNumber;
                Console.WriteLine($"What is {firstNumber} - {secondNumber}?");

                var userChoice = Console.ReadLine();

                userChoice = Helpers.ValidateResult(userChoice);

                if (int.Parse(userChoice) == difference)
                {
                    Helpers.CorrectAnswer();
                    ++score;
                    Console.WriteLine($"Current score: {score}");

                }
                else
                {
                    Helpers.IncorrectAnswer();
                }
                Helpers.GameOver(i, score);
            }
            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            Random random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                int product = firstNumber * secondNumber;
                Console.WriteLine($"What is {firstNumber} * {secondNumber}?");

                var userChoice = Console.ReadLine();

                userChoice = Helpers.ValidateResult(userChoice);

                if (int.Parse(userChoice) == product)
                {
                    Helpers.CorrectAnswer();
                    ++score;
                    Console.WriteLine($"Current score: {score}");

                }
                else
                {
                    Helpers.IncorrectAnswer();
                }
                Helpers.GameOver(i, score);
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                firstNumber = divisionNumbers[0];
                secondNumber = divisionNumbers[1];
                int dividend = firstNumber / secondNumber;

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var userChoice = Console.ReadLine();

                userChoice = Helpers.ValidateResult(userChoice);

                if (int.Parse(userChoice) == dividend)
                {
                    Helpers.CorrectAnswer();
                    ++score;
                    Console.WriteLine($"Current score: {score}");

                }
                else
                {
                    Helpers.IncorrectAnswer();
                }
                Helpers.GameOver(i, score);
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
