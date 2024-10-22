/* Objectives:
 * 
 * Make a program that runs as shown above [on the book], including a name from the user
 * 
 * **/

namespace Consolas_and_Telim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Bread is ready\nWho is the bread for?");
            name = Console.ReadLine();
            Console.WriteLine($"Noted, {name} got bread.");
        }
    }
}
