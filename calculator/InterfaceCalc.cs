﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    //интерфейс
    public interface InterfaceSimple
    {
        double Multiplication(double b);

        double Division(double b);

        double Sum(double b);

        double Subtraction(double b); //вычитание
    }
    public interface InterfaceComplex
    {
        //а - первый аргумент, b - второй
        void Put_A(double a); //сохранить а

        void Clear_A();

        double SqrtX(double b);

        double DegreeY(double b);

        double Sqrt();

        double Square();

        double Factorial();
    }
    public interface InterfaceMemory
    {
        double MemoryShow(); //показать содержимое регистра мамяти

        void Memory_Clear(); //стереть содержимое регистра мамяти

        //* / + - к регистру памяти
        void M_Multiplication(double b);

        void M_Division(double b);

        void M_Sum(double b);

        void M_Subtraction(double b); //вычитание
    }
}
