using System;
using System.Collections.Generic;

namespace HW_GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(1, "Muzaffer");
            students.Add(1, "Bulut");

            Console.WriteLine(students.Count);
        }
    }
}
