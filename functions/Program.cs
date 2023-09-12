namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CALL BY VALUE
            int a = 15;
            int b = a;
            b = 30;
            Console.WriteLine("variable a is {0}", a);

            Console.WriteLine("Using the update value function using pass by value");
            UpdateValue(a);
            Console.WriteLine("using the Update func: a = {0}", a);
        }

        // argument here makes a copy of the passed variable
        private static void UpdateValue(int b)
        {
            b = 30;
        }


    }


}