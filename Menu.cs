namespace Math_Game
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Hello {name}. It's {date}.\n");
            Console.WriteLine("Press any key to show the menu.");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - View previous games
Q - Quit the program");
                Console.WriteLine("--------------------");

                var gameSelected = Console.ReadLine().Trim().ToLower();

                switch (gameSelected)
                {
                    case "a":
                        gameEngine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game.");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game.");
                        break;
                    case "q":
                        isGameOn = false;
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    default:
                        Helpers.InvalidInput();
                        break;
                }
            } while (isGameOn);


        }
    }
}
