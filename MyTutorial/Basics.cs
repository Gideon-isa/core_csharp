using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTutorial
{
    internal class Basics
    {
        string firstName;
        string lastName;
        int age;

        public Basics(string firstName, string lastName, int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }


        public void DeclareDetails(Basics userInput)
        {
        ExistRemark:
            Console.WriteLine("Hey there am back up here");
            System.Environment.Exit(0);


            switch (userInput.age)
            {
                case 5:
                    Console.WriteLine("User entered {0}", userInput.age);
                    goto ExistRemark;

                    break;
                case 10:
                    Console.WriteLine("User entered {0}", userInput.age);
                    break;
                case 3:
                    Console.WriteLine("User entered {0}", userInput.age);
                    break;
                default:
                    Console.WriteLine("User entered {0}", userInput.age);
                    break;

            }
        }

        public static string BasicDetails()
        {
            return "In the basic details block";
        }
    }
}
