using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class InClassConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int studentCount = 25;
            if (studentCount >= 20)
            {
                Console.WriteLine("The class is getting pretty small");
            }
            else if (studentCount >= 10)
            {
                Console.WriteLine("This class is really small");
            }
            else (studentCount >= 10)
            {
                Console.WriteLine("this class is really small")
            }

            switch (studentCount)
            {
                case 12:
                    Console.WriteLine("you have exactly 12 students");
                    break;
                case 10:
                    Console.WriteLine("you have exactly 10 students");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("You have x number of students");
                    break;
                default:
                    Console.WriteLine("How many students do you have?");
                    break;


            }
            //Ternaries
            bool result = (studentCount == 10) ? true : false;
            string isGoodSize = (studentCount < 65) ? "This class is managable" : "Oh boy that's a lot of students";
        }
    }
}
