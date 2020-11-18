using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;    //Int16
            Int16 anotherSmallNumber = 16;   
            int wholeNumber = 32;    //Int32
            long largeWholeNumber = 64;  //Int64

            int newNumber = oneBytesWorth;

            //--Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.237909d;
            decimal decimalExample = 1.70000m;

            //Character
            char letter = 'j';


            //--Operatiors
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.Write(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            char space = ' ';
            //--Strings
            string stringExample = "This is a string.";
            string name = "Samuel";

            string declared;
            declared = "Now it's initialized";

            //Formatting strings
            string concatenate = stringExample + " " + name; //This is a string. Samuel
            string interpolate = $"{name}. Here is the string {stringExample}"; //Samuel. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);


            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 11, 11);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            //--Collections
            // Arrays (don't often use in C#)
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>(); //First in first out - Queues
            firstInFirstOut.Enqueue("Luke"); //Enqueue makes "Luke" the last person in line if more than 1 name in list


            // Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            // Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>(space);
            Stack<string> firstInLastOut = new Stack<string>();
        }

    }
}
