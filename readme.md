[![code checks](https://github.com/tikkchan/lab2/blob/master/.github/workflows/unit.yml)](https://github.com/tikkchan/lab2/blob/master/.github/workflows/unit.yml)
#Тестирование приложения "Калькулятор" с помощью unit test

##Было реализовано 18 тестов:
___Тест 1.___
```c#
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
```
Тест вызывает функцию Multiplication и проверяет, что функция умножения работает корректно.
```c#
public double Multiplication(double b)
        {
            return a * b;
        }
```

___Тесты 2-3.___
```c#
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
```
Тест вызывает функцию Division и проверяет, что функция деления работает корректно. Отрицательный тест вызывает функцию Division передавая в качестве параметров число, которое нужно разделить на ноль. Результат division by zero
```c#
public double Division(double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else throw new DivideByZeroException();

        }
```
___Тест 4.___
```c#
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
```
Тест вызывает функцию Sum и проверяет, что функция сложения работает корректно.
```c#
        public double Sum(double b)
        {
            return a + b;
        }
```
___Тест 5.___
```c#
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
```
Тест вызывает функцию Subtraction и проверяет, что функция вычитания работает корректно.
```c#
        public double Subtraction(double b) //вычитание
        {
            return a - b;
        }
```
___Тест 6.___
```c#
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
```
Тест вызывает функцию SqrtX и проверяет, что функция извлечения корня работает корректно.
```c#
        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }
```
___Тест 7.___
```c#
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
```
Тест вызывает функцию DegreeY и проверяют, что функция возведения в степень работает корректно.
```c#
        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }
```
___Тесты 8-9.___
```c#
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
```
Тесты вызывают функцию Sqrt и проверяют, что функция извлечения квадратного корня работает корректно. Отрицательный тест проверяет, что нельзя извлечь квадратный корень из отрицательного числа.
```c#
        public double Sqrt()
        {
            return Math.Sqrt(a);
        }
```
___Тест 10.___
```c#
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
```
Тест вызывает функцию Square и проверяют, что функция извлечения квадратного корня работает корректно.
```c#
        public double Square()
        {
            return MultA(a);
        }
```
___Тесты 11-12.___
```c#
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
```
Тесты вызывают функцию Factorial и проверяют, что функция поиска факториала числа работает корректно. Негативный тест проверяет то, что не существует факториала отрицательного числа.
```c#
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
```
___Тест 13.___
```c#
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
```
Тест вызывает функцию M_Sum и проверяют, что функция отслеживания памяти (запомнить число) работает корректно.
```c#
        public void M_Sum(double b)
        {
            memory += b;
        }
```
___Тест 14.___
```c#
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
```
Тест вызывает функцию M_Subtraction и проверяют, что функция отслеживания памяти (отнять число) работает корректно.
```c#
        public void M_Subtraction(double b)
        {
            memory -= b;
        }
```

___Тест 15.___
```c#
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
```
Тест вызывает функцию M_Multiplication и проверяют, что функция отслеживания памяти (умножить число) работает корректно.
```c#
        public void M_Multiplication(double b)
        {
            memory *= b;
        }
```

___Тест 16.___
```c#
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
```
Тест вызывает функцию M_Division и проверяют, что функция отслеживания памяти (разделить число) работает корректно.
```c#
        public void M_Division(double b)
        {
            memory /= b;
        }
```
___Тест 17.___
```c#
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
```
Тест вызывает функцию Memory_Clear и проверяют, что функция отслеживания памяти (очистка памяти) работает корректно.
```c#
        public void Memory_Clear()
        {
            memory = 0.0;
        }
```

___Тест 18.___
```c#
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
```
Тест вызывает функцию MemoryShow и проверяют, что функция отслеживания памяти (вывод числа) работает корректно.
```c#
        public double MemoryShow()
        {
            return memory;
        }
```