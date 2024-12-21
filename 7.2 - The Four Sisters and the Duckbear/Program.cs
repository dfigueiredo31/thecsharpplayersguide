namespace _7._2___The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfEggsProduced;
            int numOfEggsEachSisterGets;
            int numOfEggsDuckbearGets;

            Console.WriteLine("::::: Welcome to the chocolate farm :::::");
            Console.WriteLine("How many chocolate eggs were produced today?");
            while (!int.TryParse(Console.ReadLine(), out numOfEggsProduced))
                Console.WriteLine("Invalid int number");

            numOfEggsEachSisterGets = numOfEggsProduced / 4;
            numOfEggsDuckbearGets = numOfEggsProduced % 4;

            Console.WriteLine($"Each sister gets {numOfEggsEachSisterGets}");
            Console.WriteLine($"Duckbear gets the remainder {numOfEggsDuckbearGets} egg(s)");
        }
    }
}
