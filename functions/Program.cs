namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. CALL BY VALUE
            int a = 15;
            int b = a;
            b = 30;
            Console.WriteLine("variable a is {0}", a);

            Console.WriteLine("Using the update value function using pass by value");
            UpdateValue(a);
            Console.WriteLine("using the Update func: a = {0}\n\n", a);


            // 2. VALUE WITH REFERENCE TYPE
            Employee Emp1 = new Employee();
            Emp1.EmployeeID = 100;
            Emp1.Name = "Smith";

            Employee Emp2 = Emp1;
            Emp1.Name = "James";
            Console.WriteLine($"Emp1 Name = {Emp1.Name}");
            Console.WriteLine($"Emp2 Name = {Emp2.Name}\n\n");

            // EXAMPLE TWO 
            // When we pass reference Emp3 of the Employee object to the UpdateName method,
            // the memory location reference is copied to the local object Emp4 of the method UpdateName.
            // And both (Emp3 and EmpA) are pointing to the same memory location.
            // So, changing the Name variable’s value will change the object’s value in memory,
            // and the changes will reflect in both the references,
            // i.e., Emp3 and EmpA, and the updated value Henry will print on the console
            Employee Emp3 = new Employee();
            Emp3.EmployeeID = 200;
            Emp3.Name = "Jude";
            // invoking the method
            UpdateName(Emp3);
            Console.WriteLine($"After the update name method, Emp3 is {Emp3.Name}\n\n");


            // reference is passed by value in C#, not by reference.
            // The null won't affect the value Gideon
            // hence, the name Gideon is still printed on the console
            //when we set EmpB = null; then the EmpB references are deleted.
            //But still, the Emp4 reference to the Employee object exists.

            // If we want to make Emp4 also null,
            // when you set EmpB as null, then you have to pass it to the method via reference,
            // which is done in C# by using the ref Keyword
            Employee Emp4 = new Employee();
            Emp4.Name = "Gideon";
            Emp4.EmployeeID = 400;

            UpdateNameTwo(Emp4);
            Console.WriteLine($"Emp4 Name = {Emp4.Name}\n\n");


            // CALL BY REFERNCE

            // 1 CALL BY REFERNCE WITH VALUE TYPE
            int c = 24;

            // where refernce is the memory address of c
            UpdateValue2(ref c);
            Console.WriteLine($"The value of c after calling the updateValue with a refernce argument is {c}");

            // 2 CALL BY REFERENCE WITH REFERENCE TYPE
            Employee Emp5 = new Employee();
            Emp5.Name = "David";
            Emp5.EmployeeID = 500;

            UpdateNameThree(ref Emp5);
            Console.WriteLine($"Emp5 is {Emp5.Name}");



        }

        private static void UpdateNameThree(ref Employee emp5)
        {
            emp5 = null;
        }

        // argument here makes a copy of the passed variable
        private static void UpdateValue(int b)
        {
            b = 30;
        }

        // 
        private static void UpdateName(Employee EmpA)
        {
            EmpA.Name = "Henry";
            Console.Write("In Update method ");
            Console.WriteLine($"Emp3 Name = {EmpA.Name}");
        }

        private static void UpdateNameTwo(Employee EmpB)
        {
            EmpB = null;
        }

        private static void UpdateValue2(ref int a)
        {
            a = 40;
        }


        // CLASS EMPLOYEE
        public class Employee
        {
            public int EmployeeID;
            public string Name;
        }


    }


}