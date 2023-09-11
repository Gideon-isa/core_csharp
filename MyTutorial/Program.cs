using System.Reflection.Emit;

namespace MyTutorial
{
    internal class Program
    {
        static int x = 67;
        readonly int z;
        int y;

        public Program() 
        {
            x = 23;
            //z = 29;
        }

        private static bool AskUser()
        {
            Console.WriteLine("\nType in your name favourite number? " +
                "\nAnd Please type a non numeric keys to end the programme");
            bool isValid = int.TryParse(Console.ReadLine(), out int result);

            if (!isValid) 
            {
                Console.WriteLine("Bye!");
            }
            else
            {
                Console.WriteLine("You entered {0}", result);
            }
            

            return isValid;
        }
        static void Main(string[] args)
        {

            // bool toStopProgramm = true;


            //toStopProgramm =  AskUser();

            //Console.Write("Enter your first name ");
            //string? firstName = Console.ReadLine();


            //Console.Write("Enter your last name ");
            //string? lastName = Console.ReadLine();


            //Console.WriteLine("Please enter in that number");
            //int userAge = (int) Convert.ToInt16(Console.ReadLine());

            //Basics myBasics = new Basics(firstName, lastName, userAge);

            //myBasics.DeclareDetails(myBasics);

            int count = 1;
        label1:
            Console.WriteLine(count);
            int a = count++;
            Console.WriteLine($"the count is now {count}");
            Console.WriteLine($"the count of a is {a}");
            if (count <= 10)
            {
                goto label1;
            }
            

        }

    }
}