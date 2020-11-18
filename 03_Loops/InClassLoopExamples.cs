using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            //For loop
            for (int i = 0; i <= studentCount; i++) ;
            {
                Console.WriteLine(i);
            }

            string[] names = { "Michael", "simon", "peyton", "casey" };
            Console.WriteLine(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length); // gives the number of strings in the array

            while (studentCount > 0)
            {
                Console.WriteLine(studentCount);
                studentCount --;
            }
        }
    }
}
