using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Person
    {
        /* Q1
        #region attributes
        string[] Name;
        int[] Age;
        int Size;
        #endregion

        public int size
        {
            get { return Size; }
            set { Size = value; }
        }

        #region getters and setters
        public string getName(int index)
        {
            if (index >= 0 && index < Size)
            {
                return Name[index];
            }
            else
            {
                Console.WriteLine("index not valid");
                return "index is not vaild";
            }
        }
        public int getAge(int index)
        {
            if (index >= 0 && index < Size)
            {
                return Age[index];
            }
            else
            {
                Console.WriteLine("index not valid");
                return -1;
            }
        }
        #endregion


        #region constructor
        public Person(int size)
        {
            Size = size;
            Name = new string[size];
            Age = new int[size];
        }
        #endregion
        #region methods
        public void AddPerson(int index, string name, int age)
        {
            if (index >= 0 || index < Size)
            {
                Name[index] = name;
                Age[index] = age;
            }
            else
            {
                Console.WriteLine("index not vaild");
            }
        }

        #endregion
        */

        /* Q3
#region attributes
string[] Name;
int[] Age;
int Size;

#endregion

public int size
{
    get { return Size; }
    set { Size = value; }
}

#region constructor
public Person(int size)
{
    Size = size;
    Name = new string[size];
    Age = new int[size];
}

#endregion
#region methods
public void AddPerson(int index, string name, int age)
{
    if (index >= 0 && index < Size)
    {
        Name[index] = name;
        Age[index] = age;
    }
    else
    {
        Console.WriteLine("index not valid");
    }
}
public void getOldestName()
{
    if (Size == 0) Console.WriteLine("No persons available");
    int maxAge = Age[0];
    string oldestName = Name[0];
    for (int i = 1; i < Size; i++)
    {
        if (Age[i] > maxAge)
        {
            maxAge = Age[i];
            oldestName = Name[i];
        }
    }
    Console.WriteLine($"Oldest Person is: {oldestName} \nand his age is {maxAge}"); ;
}
#endregion
*/
}
}
