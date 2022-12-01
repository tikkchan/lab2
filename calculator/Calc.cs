using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //класс, реализующий интерфейс InterfaceCalc
    public class SimpleOperations : InterfaceSimple
    {
        private double a = 0;

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else throw new DivideByZeroException();

        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b) //вычитание
        {
            return a - b;
        }

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }
    }
    public class ComplexOperations : InterfaceComplex
    {
        private double a = 0;
        
        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        protected double MultA(double a)
        {
            double result;
            result = a * a;
            return result;
        }

        public double Square()
        {
            return MultA(a);
        }

        public double Factorial()
        {
            double f = 1;

            if (a < 0) {
                throw new Exception("Факторила отрицательного числа не существует");
            };

            for (int i = 1; i <= a; i++)
                f *= (double)i;

            return f;
        }

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

    }
    public class MemoryWork : InterfaceMemory
    {
        private double memory = 0;
        //показать содержимое регистра мамяти
        public double MemoryShow()
        {
            return memory;
        }

        //стереть содержимое регистра мамяти
        public void Memory_Clear()
        {
            memory = 0.0;
        }

        //* / + - к регистру памяти
        public void M_Multiplication(double b)
        {
            memory *= b;
        }

        public void M_Division(double b)
        {
            memory /= b;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }

    }
}
