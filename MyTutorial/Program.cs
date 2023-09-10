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
          
            bool toStopProgramm = true;
            
            while (toStopProgramm)
            {
                toStopProgramm =  AskUser();

            }

        }
    }
}