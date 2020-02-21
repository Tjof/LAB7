using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB_6;
using System.Collections.Generic;
using System.Text;

namespace LAB6Tests
{
    [TestClass]
    public class Number6Tests
    {
        [TestMethod]
        public void Test1Method1()
        {
            int n = 30;
            Lab6num1 num1 = new Lab6num1();
            Assert.ThrowsException<ArgumentException>(() => num1.Num1(n), "не обработано колличество символов алфавита.");
        }

        [TestMethod]
        public void Test1Method2()
        {
            int n = 3;
            string expected = "ABC";

            Lab6num1 num1 = new Lab6num1();
            string stringResult = num1.Num1(n);
            Assert.AreEqual(expected, stringResult);
        }

        [TestMethod]
        public void Test2Method1()
        {
            double a = 0;
            double b = 4;
            double c = 3.14;
            Lab6num2 num2 = new Lab6num2();
            Assert.ThrowsException<ArgumentException>(() => num2.Num2(a, b, c), "a равно нулю.");
        }

        [TestMethod]
        public void Test2Method2()
        {
            double a = 1;
            double b = 10;
            double c = -1200;
            double[] expected = { 30, -40 };

            Lab6num2 num2 = new Lab6num2();
            double[] stringResult = num2.Num2(a, b, c);
            Array.Equals(expected, stringResult);
        }
        
        [TestMethod]
        public void Test2Method3()
        {
            double a = 1;
            double b = 10;
            double c = 1200;
            double[] expected = { };

            Lab6num2 num2 = new Lab6num2();
            double[] stringResult = num2.Num2(a, b, c);
            Array.Equals(expected, stringResult);
        }
        
        [TestMethod]
        public void Test2Method4()
        {
            double a = 1;
            double b = -4;
            double c = 4;
            double[] expected = { 2 };

            Lab6num2 num2 = new Lab6num2();
            double[] stringResult = num2.Num2(a, b, c);
            Array.Equals(expected, stringResult);
        }

        [TestMethod]
        public void Test3Method1()
        {
            int n = -1302;

            Lab6num3 num3 = new Lab6num3();
            Assert.ThrowsException<ArgumentException>(() => num3.Num3(n), "не обработан отрицательный год.");
        }
        
        [TestMethod]
        public void Test3Method2()
        {
            int n = 2020;
            int expected = 366;

            Lab6num3 num3 = new Lab6num3();
            int yearResult = num3.Num3(n);
            Assert.AreEqual(expected, yearResult);
        }

        [TestMethod]
        public void Test3Method3()
        {
            int n = 2019;
            int expected = 365;

            Lab6num3 num3 = new Lab6num3();
            int yearResult = num3.Num3(n);
            Assert.AreEqual(expected, yearResult);
        }

        [TestMethod]
        public void Test4Method1()
        {
            string email = "test@test_ru";

            Lab6num4 num4 = new Lab6num4();
            Assert.ThrowsException<ArgumentException>(() => num4.Num4(email), "не обработан почтовый ящик.");
        }

        [TestMethod]
        public void Test4Method2()
        {
            string email = "test@test.ru";
            bool expected = true;

            Lab6num4 num4 = new Lab6num4();
            bool resultRegex = num4.Num4(email);
            Assert.AreEqual(expected, resultRegex);
        }

        [TestMethod]
        public void Test5Method1()
        {
            string count = "1234";
            int expected = 10;

            Lab6num5 num5 = new Lab6num5();
            int countResult = num5.Num5(count);
            Assert.AreEqual(expected, countResult);
        }
    }
}
