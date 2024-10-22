/* Objectives:
 * 
 * Rebuild the program above [on the book] on your computer.
 * Add comments near each of the four variables that describe what they store. You must use at least on of each comment type (// and /* *\/).
 * Find the bug in the text displayed and fix it.
 * 
 * Answer this question: Aside from comments, what else could you do to make this code more understandable?
 * Ans: string interpolation (or string formatting), better named variables. 
 * 
 * **/


namespace TheThingNamer3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * ORIGINAL
             * 
                Console.WriteLine("What kind of thing are we talking about?");
                string a = Console.ReadLine();
                Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
                string b = Console.ReadLine();
                string c = "of Doom";
                string d = "3000";
                Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
            */


            /*
             * Commented and bug fixed
             */

            //Item type input
            Console.WriteLine("What kind of thing are we talking about?");
            string itemType = Console.ReadLine();

            //Item atribute input
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string itemAtribute = Console.ReadLine();
            
            //Other atributes
            string badassness = "Doom";  //"of" removed
            string badassnessLevel = "3000";

            //String formatting for better readeability
            Console.WriteLine("The {0} {1} of {2} {3}!", itemAtribute, itemType, badassness, badassnessLevel);
        }
    }
}
