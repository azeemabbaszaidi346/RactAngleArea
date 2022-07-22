using System;

namespace RactAngleArea
{
    class Program
    {
      
        static void Main(string[] args)
        {
            // (1.Length Of Ractangle.............)
            Console.WriteLine("1.Lenght Of Ractangle ");
            int Length, Width;
            Console.WriteLine("\nEnter Lenght");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Width");
            Width = Convert.ToInt32(Console.ReadLine());
            int Area = Length * Width;
            Console.WriteLine("\nArea Of Ractangle : {0} ", Area);        

            // (2.Average Of Three Number..................)           
            Console.WriteLine("\n2.Average Of Three Number");
            int num1, num2, num3, Average;
            Console.WriteLine("\nEnter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Num 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            Average = (num1 + num2 + num3) / 3;
            Console.WriteLine("\nAverage Of Three Number : {0}", Average);
         

            // (3.C# Program to Count Number of Words in a String......)
            Console.WriteLine("\n3.Program to Count Number of Words in a String");
            string sentence;
            Console.Write("Enter String  : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words :" + words.Length);
        
            //(4.Find Number is Even or Odd using if else Statement in C# (with static method):.........)
            Console.WriteLine("\n4.Find Number is Even or Odd using if else Statement");
            static bool BoolNum(int num)
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int Num;
            Console.WriteLine("Enter Any Number");
            Num = Convert.ToInt32(Console.ReadLine());

            if (BoolNum(Num))
            {
                Console.WriteLine("Number Is Even", Num);
            }
            else
            {
                Console.WriteLine("Number Is Odd", Num);
            }

           // (5. Finding the biggest of three numbers in C#)
            Console.WriteLine("\n5.The Greatest Number Among Three Numbers");
            int first, second, third;           
            Console.WriteLine("Enter the first number : ");
            first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            third = int.Parse(Console.ReadLine());
            if (first > second)
            {

                if (first > third)
                {
                    Console.WriteLine("First largest number : " + first);
                }
                else
                {
                    Console.WriteLine("Third largest number : " + third);
                }
            }
            else
            {
                if (second > third)
                {
                    Console.WriteLine("Second largest number : " + second);
                }
                else
                {
                    Console.WriteLine("Third largest number : " + third);
                }

            }
                Console.ReadLine();
        }
    }
}
