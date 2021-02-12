using System;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Subtract(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] numbers)
        {
            throw new NotImplementedException();
        }

        public double Divide(params double[] numbers)
        {
            if (numbers.Length < 2) throw new Exception("Need at least 2 numbers");

            double result = 0;  

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == 0){
                    throw new Exception("Cant be divided by 0");
                }

                result = numbers[i] / numbers[i+1];
            }

            return result;
        }

        public double Factorial(double number)
        {
            throw new NotImplementedException();
        }
    }
}