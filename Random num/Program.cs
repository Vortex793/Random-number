using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_num
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Which part of the code would you like to run (choose between 1-4)");
            Console.WriteLine("1 - Random Numbers");
            Console.WriteLine("2 - Adder");
            Console.WriteLine("3 - Distance");
            Console.WriteLine("4 - Hypotenuse");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1) Part1();
            else if (choice == 2) Part2();
            else if (choice == 3) Part3();
            //else if (choice == 4) Part4();

            else Console.WriteLine("Invalid number :(");

            Console.ReadLine();

        
            
        }

        static void Part1()
        {
            Random generator = new Random();

            int minNum, maxNum;

            Console.Write("Enter the minimum number: ");
            minNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum number: ");
            maxNum = Convert.ToInt32(Console.ReadLine());

            if (minNum > maxNum)
            {
                Console.WriteLine("Minimum number cannot be greater than maximum number.");
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                int randomNum = generator.Next(minNum, maxNum + 1);
                Console.WriteLine($"Random number {i + 1}: {randomNum}");
            }
        }

        static void Part2()
        {
            Console.Clear();
            Random generator = new Random();

            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);
            int sum = dice1 + dice2;

            Console.Write("Hit enter to roll the 2 dice: ");
            Console.ReadLine();

            Console.WriteLine($"Dice 1: {dice1}");
            Console.WriteLine($"Dice 2: {dice2}");
            Console.WriteLine($"Sum: {sum}");
        }

        static void Part3()
        {
            Console.Clear();

            int minNum, maxNum;

            Console.Write("Enter the minimum number: ");
            minNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the maximum number: ");
            maxNum = Convert.ToInt32(Console.ReadLine());

            if (minNum > maxNum)
            {
                Console.WriteLine("Minimum number cannot be greater than maximum number.");
                return;
            }

        }
    }
}
