//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    struct PhoneBook
//    {
//        #region attributes

//        string[] Names;
//        long[] Numbers;
//        int Size;

//        #endregion

//        public int size
//        {
//            get { return Size; }
//            private set { Size = value; }
//        }

//        #region Using Getters
//        public long GetPersonNumber(string name)
//        {
//            if (Names is not null && Numbers is not null)
//            {
//                for (int i = 0; i < Size; i++)
//                {
//                    if (Names[i] == name)
//                    {
//                        return Numbers[i];
//                    }
//                }
//            }
//            return -1;
//        }
//        #endregion

//        #region Using Setter
//        public void SetPersonNumber(string name, long newNumber)
//        {
//            if (Names is not null && Numbers is not null)
//            {
//                for (int i = 0; i < Size; i++)
//                {
//                    if (Names[i] == name)
//                    {
//                        Numbers[i] = newNumber;
//                    }
//                }
//            }
//        }
//        #endregion



//        #region Indexer

//        // Special Type of property using keyword this
//        // this => refer to PhoneBook struct
//        public long this[string name] 
//        {
//            get
//            {
//                if (Names is not null && Numbers is not null)
//                {
//                    for (int i = 0; i < Size; i++)
//                    {
//                        if (Names[i] == name)
//                        {
//                            return Numbers[i];
//                        }
//                    }
//                }
//                return -1;
//            }
//            set 
//            {
//                if (Names is not null && Numbers is not null)
//                {
//                    for (int i = 0; i < Size; i++)
//                    {
//                        if (Names[i] == name)
//                        {
//                            Numbers[i] = value;
//                        }
//                    }
//                }

//            }

//        }



//        //method to get a person number by Index

//        public string this [int index]
//        {
//            get
//            {
//                if (index >= 0 && index < Size)
//                {
//                    return $"{Names[index]} : {Numbers[index]}";
//                }
//                return "Index out of range";
//            }
//        }

//        #endregion


//        #region constructor

//        public PhoneBook(int size)
//        {
//            Size = size;
//            Names = new string[size];
//            Numbers = new long[size];
//        }

//        #endregion
//        #region methods
//        // method to add a person with name and number
//        // Position , Name , Number
//        public void addPerson(int position , string name , long num) { 
        
//            if (name != null && num != null)
//            {
//                if (position >= 0 || position < Size)
//                {
//                    Names[position] = name;
//                    Numbers[position] = num;
//                }
//            }
//        }

//        #endregion

//    }
//}
