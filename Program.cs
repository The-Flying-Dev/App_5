using MathsGame;

namespace MathGame;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating an Object from the Menu Class
        var menu = new Menu();

        var date = DateTime.UtcNow;

        // Assigns the value from the GetName() method to the string variable name
        string name = Helpers.GetName();

        // Passes the name variable above as an argument to the Menu() method
        menu.ShowMenu(name, date);

        /* Local function definition inside main
           cannot include the memeber access modifier, all local functions are private
           including an access modifier, the private keyword generates a compiler error CS0106
        */
        // string GetName()
        // {
        //     Console.WriteLine("Please type your name");
        //     var name = Console.ReadLine();
        //     return name;
        // }
    }
}
