using System;

namespace Week7.Calcolatrice.Core
{
    public class Calcolatrice
    {
        public double Somma(double x, double y)
        {
            double Sum = x + y;
            return Sum;
        }

        public double Sottrazione(double x, double y)
        {
            double Sub = x - y;
            return Sub;
        }

        public double Moltiplicazione(double x, double y)
        {
            double Mul = x * y;
            return Mul;
        }


        public double Div(double x, double y)
        {
            double Div = x / y;
            return Div; 
        }




    }
}

