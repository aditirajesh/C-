// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter integer to find factorial for: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0) {
                Console.WriteLine("The number must be a positive integer. Try again");
            } else{
                int result = FindFactorial(number,1);
                Console.WriteLine("The factorial is "+result);
            };
        }

        static int FindFactorial(int number,int result) {
            result *= number;
            number -= 1;
            if (number>0) {
                return FindFactorial(number,result);
            } else {
                return result;
            };

        }
    }
}
