namespace _8._1___The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //::::: The Defense Of Consolas :::::
            int row;
            int col;

            Console.Title = "The Defense Of Consolas";

            Console.Write("Target row: ");
            while(!int.TryParse(Console.ReadLine(), out row))
                Console.Write("Invalid!");

            Console.Write("Target col: ");
            while (!int.TryParse(Console.ReadLine(), out col))
                Console.Write("Invalid!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deploy to:");
            Console.WriteLine($"({row},{col -1})");
            Console.WriteLine($"({row - 1},{col})");
            Console.WriteLine($"({row},{col + 1})");
            Console.WriteLine($"({row + 1},{col})");

            Console.Beep(40, 2000);

        }
    }
}
