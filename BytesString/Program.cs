using System.Text;

namespace BytesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            byte[] buffer = new byte[4];

            //string myName = "Gid";
            //buffer = Encoding.ASCII.GetBytes(myName);

            //byte[] buffer = new byte[4];
            buffer[0] = 0;
            buffer[1] = 56;
            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }

            // Console.WriteLine(buffer.ToString);
            


        }
    }
}