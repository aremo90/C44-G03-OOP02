namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Person p1 = new Person(3);
            p1.AddPerson(0, "Alice", 30);
            p1.AddPerson(1, "Bob", 25);
            p1.AddPerson(2, "Charlie", 35);

            for (int i = 0; i < p1.size; i++)
            {
                Console.WriteLine($"Name: {p1.getName(i)}, Age: {p1.getAge(i)}");
            }

            #endregion
        }
    }
}
