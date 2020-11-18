using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExample
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 32;

            byte someByte = 23;   //up to 255

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.4352345;
            float someFLoat = 23.4352345f;
            decimal someDecimal = 23.453245m;

            char letter = 'm';
            bool trueOrFalseValue = true;

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "Samuel Mourfield";
            string specialCharacters = "\"Sam\"";

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan age = DateTime.Now - new DateTime(1988, 04, 11);
            Console.WriteLine(age);

            string[] names = { "Casey", "Michael", "simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);

            Console.WriteLine(fruits[1]);
            Console.WriteLine(dictionary['x']);
           
        }
    }
}
