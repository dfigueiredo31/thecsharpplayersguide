namespace _7._1___The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tArea, tBase, tHeight;

            Console.WriteLine("::::: Triangle Area Calculator :::::");
            
            Console.WriteLine("Enter triangle base: ");
            while(!double.TryParse(Console.ReadLine(), out tBase))
                Console.WriteLine("Invalid base value");

            Console.WriteLine("Enter triangle height: ");
            while(!double.TryParse(Console.ReadLine(), out tHeight))
                Console.WriteLine("Invalid height value");

            tArea = (tBase *  tHeight) / 2;
            Console.WriteLine($"The triangle area is {tArea}");
        }
    }
}
