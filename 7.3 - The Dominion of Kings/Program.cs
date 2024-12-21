namespace _7._3___The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numOfProvinces;
            uint numOfDuchies;
            uint numOfEstates;
            uint totalScore;
            
            Console.WriteLine("::::: Which kingdom is the greatest of them all? :::::");
            
            Console.WriteLine("How many provinces do you have?");
            while (!uint.TryParse(Console.ReadLine(), out numOfProvinces))
                Console.WriteLine("Invlid num");
            
            Console.WriteLine("How many duchies do you have?");
            while (!uint.TryParse(Console.ReadLine(), out numOfDuchies))
                Console.WriteLine("Invlid num");

            Console.WriteLine("How many estates do you have?");
            while (!uint.TryParse(Console.ReadLine(), out numOfEstates))
                Console.WriteLine("Invlid num");

            totalScore = numOfProvinces * 6 + numOfDuchies * 3 + numOfEstates;

            Console.WriteLine($"Your total score is {totalScore}, my King");
        }
    }
}
