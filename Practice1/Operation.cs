using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    internal class Operation
    {

        
        

        double add, sub, mul, div;

        

        public double Add(double num1, double num2)
        {
            return add = num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return sub = num1 - num2;
        }

        public double Mul(double num1, double num2)
        {
            return mul = num1 * num2;
        }

        public double Div(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0 || num2 == 0 || num1 == 0)
            {
                Console.WriteLine("Cannot be divided");
            }

            return div = num1 / num2;


        }



    }
}
