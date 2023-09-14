namespace FunctionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //RecursionMethod(4);

            //EXECERSISE 
            //Swap two numbers
            int firstNumber  = 5;
            int secondNumber = 6;
            //int output = 0;

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
          


          
            
        }

        private static void RecursionMethod(int a)
        {
            if (a > 0)
            {
                RecursionMethod(a -  1);
                Console.WriteLine($"The value of a {a}");
            }
        }
    }
}