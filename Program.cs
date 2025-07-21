namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct

            /*
             * Struct value type
             * struct comes from C language
             * struct dosen't allow inheritance
             * struct [private, public , internal]
             */

            //Point p1 = new Point(10, 20);

            //Console.WriteLine(p1);

            #endregion
            #region oop def

            /*
             * OOP => Object Oriented Programming
             * Foucs on objects
             * c# pure OOP
             * 
             * 1. Encapsulation
             * 2. Inheritance
             * 3. Polymorphism
             * 4. Abstraction

             */


            #endregion
            #region Employee

            //Employee emp1 = new Employee(1, "Jon" , 50000);
            //Console.WriteLine(emp1);

            //emp1.Id = -2;
            //emp1.Name = "ay7aga";

            //Console.WriteLine(emp1.getName());
            //emp1.SetName("Mohamed");
            //Console.WriteLine(emp1.getName());

            //emp1.salary = 100000;
            //Console.WriteLine(emp1.salary);

            //emp1.Age = 30;
            //Console.WriteLine($":{ emp1.Age }");

            #endregion
            #region Indexer

            //PhoneBook Note = new PhoneBook(3);

            //Note.addPerson(0, "Ahmed", 123);
            //Note.addPerson(1, "Hamza", 456);
            //Note.addPerson(2, "Ahmed", 789);

            //Console.WriteLine(Note.GetPersonNumber("Ahmed"));
            //Console.WriteLine("===========================");

            //Note.SetPersonNumber("Ahmed", 111);
            //Console.WriteLine(Note.GetPersonNumber("Ahmed"));

            //Note["Hamza"] = 222;

            //Console.WriteLine(Note[4]);

            #endregion
        }
    }
}
