using Math_Game;

var menu = new Menu();
DateTime date = DateTime.Now;
string name = Helpers.GetName();

menu.ShowMenu(name, date);
Console.ReadKey();





