using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string temp1, temp2;

            //get input
            Console.WriteLine("First number: ");
            temp1 = Console.ReadLine();
            num1 = System.Convert.ToDouble(temp1);
            Console.Out.WriteLine("Second number: ");
            temp2 = Console.ReadLine();
            num2 = System.Convert.ToDouble(temp2);

            //use method calls for output
            Console.WriteLine(num1 + " + " + num2 + " = " + add(num1, num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + subtract(num1, num2));
            Console.WriteLine(num1 + " * " + num2 + " = " + multiply(num1, num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + divide(num1, num2));
            Console.WriteLine(num1 + " % " + num2 + " = " + modulus(num1, num2));

            //sustain the window
            Console.ReadKey();
        }

        //multiplication method. takes two double params & returns double named "product"
        public static double multiply(double num1, double num2)
        {
            double product = num1 * num2;

            return product;
        }
        
        //division method. takes two double params & returns double named "quotient"
        public static double divide(double num1, double num2)
        {
            double quotient = num1 / num2;

            return quotient;
        }

        //addition method. takes two double params & returns double named "sum"
        public static double add(double num1, double num2)
        {
            double sum = num1 + num2;

            return sum;
        }

        //subtraction method. takes two double params & returns double named "difference"
        public static double subtract(double num1, double num2)
        {
            double difference = num1 - num2;

            return difference;
        }

        //modulus method. takes two double params & returns double named "remainder"
        public static double modulus(double num1, double num2)
        {
            double remainder = num1 % num2;

            return remainder;
        }
        
    }
}
