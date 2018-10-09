using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace katasolving
{
    public class Solvers
    {
        public string RGBToHex(int r, int g, int b)
        {
            string final = "";
            int temp = 0;
            int[] colorN = { r, g, b };
            foreach (var num in colorN)
            {
                temp = num;
                if (temp > 255)
                    temp = 255;
                if (temp < 0)
                    temp = 0;
                final += temp.ToString("X2");
            }

            return final;
        }
        public string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
        public bool IsLockNessMonster(string sentence)
        {
            string actual = sentence.ToLower();
            return (actual.Contains("tree fiddy") || actual.Contains("tree fifty") || actual.Contains("3.50"));
        }
        public float Combat(float health, float damage)
        {
            var final = health - damage;
            if (final <= 0)
                return 0;
            else
                return final;
        }
        public string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi <= 18.5)
                return "Underweight";
            else if (bmi <= 25)
                return "Normal";
            else if (bmi <= 30)
                return "Overweight";
            else
                return "Obese";
        }
        public int GetSum(int a, int b)
        {
            //Good Luck!
            if (a == b)
                return a;
            int count = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                    count += i;
            }
            if (b < a)
            {
                for (int i = b; i <= a; i++)
                    count += i;
            }
            return count;
        }
        public string ReverseWords(string str)
        {
            return System.String.Join(" ", str.Split(' ').Reverse());
        }
        public bool IsDivisible(int wallLength, int pixelSize)
        {
            return ((wallLength % pixelSize) == 0);
        }
        public bool Narcissistic(int value)
        {
            // Code me
            string numberS = value.ToString();
            double final = 0;
            double temp = 0;
            foreach (char n in numberS)
            {
                temp = (int)n - 48;
                final += Math.Pow(temp, numberS.Length);
            }
            //Console.WriteLine(final);
            return (final == value);
        }
        public string Greet()
        {
            return "hello world";
            // Write a public static method "greet" that returns "hello world!"
        }
        public int Solution(int value)
        {
            // Magic Happens
            int total = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    total += i;
            }
            return total;
        }
        public int NthFib(int n)
        {
            // Return the n-th number in the Fibonacci Sequence
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            else
                return NthFib(n - 1) + NthFib(n - 2);
        }
        public int BouncingBall(double h, double bounce, double window)
        {
            // your code
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                return -1;

            int count = 0;
            double x = h;
            while (x > window)
            {
                count++;
                x = x * bounce;
                if (x > window)
                    count++;
            }

            return count;
        }
    }
}
