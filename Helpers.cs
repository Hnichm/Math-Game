using Math_Game.Models;
using System.Security.Cryptography.X509Certificates;

namespace Math_Game
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game> { };
        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Division);

            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }

            Console.WriteLine("-------------");
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void InvalidInput()
        {
            Console.WriteLine("Invalid input.");
        }

        internal static void IncorrectAnswer()
        {
            Console.WriteLine("Incorrect answer, please press any key for the next question.");
            Console.ReadLine();
        }

        internal static void CorrectAnswer()
        {
            Console.WriteLine("Correct, please press any key for the next question.");
            Console.ReadLine();
        }

        internal static void GameOver(int round, int score)
        {
            if (round == 4)
            {
                Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }

        internal static string ValidateResult(string userChoice)
        {
            while (string.IsNullOrEmpty(userChoice) || !Int32.TryParse(userChoice, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                userChoice = Console.ReadLine();
            }
            return userChoice;
        }

        internal static string GetName()
        {

            Console.WriteLine("Please type your name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name, please input a name.");
                name = Console.ReadLine();
            }
            return name;

        }
    }
}
