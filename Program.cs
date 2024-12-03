/*
Write a program to print the first n natural number using recursion
*/

//the function or method calls itself
//wouldn't have to be public
//string to space and print out numbers?

namespace Assignment_5._2_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            //Console.WriteLine("Please enter any number: ");
            Console.WriteLine("Please enter a single digit number: ");
            //single digit numbers for simplicity
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The first " + n + " natural numbers are:");
            recursion(n);
        }
        static void recursion(int n)
        {
            if (n == 0)
            {
                return;
            }
            recursion(n - 1);
            //add space
            Console.Write(n + " ");
        }
    }
}
