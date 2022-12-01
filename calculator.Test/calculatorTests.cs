using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace calculator.Test
{
    [TestClass]
    public class calculatorTests
    {
        [TestMethod]
        public void MultPositive()
        {
            // Настройка среды
            double a = 2;
            double b = 3;
            double expected = 6;

            // Выполнение действий
            SimpleOperations S = new SimpleOperations();
            S.Put_A(a);
            double actual = S.Multiplication(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionPositive()
        {
            // Настройка среды
            double a = 6;
            double b = 3;
            double expected = 2;

            // Выполнение действий
            SimpleOperations S = new SimpleOperations();
            S.Put_A(a);
            double actual = S.Division(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionNegative()
        {
            // Настройка среды
            double a = 6;
            double b = 0;

            // Выполнение действий
            SimpleOperations S = new SimpleOperations();
            S.Put_A(a);
            var actual = S.Division(b);
            // Сравнение
        }

        [TestMethod]
        public void SumPositive()
        {
            // Настройка среды
            double a = 2;
            double b = 3;
            double expected = 5;

            // Выполнение действий
            SimpleOperations S = new SimpleOperations();
            S.Put_A(a);
            double actual = S.Sum(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubstractionPositive()
        {
            // Настройка среды
            double a = 6;
            double b = 3;
            double expected = 3;

            // Выполнение действий
            SimpleOperations S = new SimpleOperations();
            S.Put_A(a);
            double actual = S.Subtraction(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SqrtXPositive()
        {
            // Настройка среды
            double a = 9;
            double b = 2;
            double expected = 3;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.SqrtX(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DegreePositive()
        {
            // Настройка среды
            double a = 9;
            double b = 2;
            double expected = 81;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.DegreeY(b);
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SqrtPositive()
        {
            // Настройка среды
            double a = 81;
            double expected = 9;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.Sqrt();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SqrtNegative()
        {
            // Настройка среды
            double a = -1;
            double expected = double.NaN;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.Sqrt();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SquarePositive()
        {
            // Настройка среды
            double a = 9;
            double expected = 81;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.Square();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FactorialPositive()
        {
            // Настройка среды
            double a = 5;
            double expected = 120;

            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.Factorial();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FactorialPNegative()
        {
            // Настройка среды
            double a = -1;


            // Выполнение действий
            ComplexOperations C = new ComplexOperations();
            C.Put_A(a);
            double actual = C.Factorial();
            // Сравнение
        }

        [TestMethod]
        public void MemorySumPositive()
        {
            // Настройка среды
            double a = 3;
            double b = 5;
            double expected = 8;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            M.M_Sum(a);
            M.M_Sum(b);
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MemorySubstractionPositive()
        {
            // Настройка среды
            double a = 5;
            double b = 3;
            double expected = 2;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            M.M_Sum(a);
            M.M_Subtraction(b);
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MemoryMultiplicationPositive()
        {
            // Настройка среды
            double a = 5;
            double b = 3;
            double expected = 15;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            M.M_Sum(a);
            M.M_Multiplication(b);
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MemoryDivisionPositive()
        {
            // Настройка среды
            double a = 20;
            double b = 5;
            double expected = 4;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            M.M_Sum(a);
            M.M_Division(b);
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MemoryClearPositive()
        {
            // Настройка среды
            double a = 20;
            double expected = 0;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            M.M_Sum(a);
            M.Memory_Clear();
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MemoryShowPositive()
        {
            // Настройка среды
            double expected = 0;

            // Выполнение действий
            MemoryWork M = new MemoryWork();
            double actual = M.MemoryShow();
            // Сравнение
            Assert.AreEqual(expected, actual);
        }



    }
}
