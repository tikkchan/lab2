﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        SimpleOperations S;
        ComplexOperations C;
        MemoryWork M;

        int k; //количество нажатий кнопки MRC

        public Form1()
        {
            InitializeComponent();

            S = new SimpleOperations();
            C = new ComplexOperations();
            M = new MemoryWork();

            labelNumber.Text = "0";
        }

        //кнопка Очистка (CE)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        //кнопка изменения знака у числа
        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "0";

            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "1";

            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "2";

            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "3";

            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "4";

            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "5";

            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "6";

            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "7";

            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "8";

            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelNumber.Text += "9";

            CorrectNumber();
        }

        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }



        //кнопка Равно
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!buttonMult.Enabled)
                labelNumber.Text = S.Multiplication(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDiv.Enabled)
                labelNumber.Text = S.Division(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonPlus.Enabled)
                labelNumber.Text = S.Sum(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonMinus.Enabled)
                labelNumber.Text = S.Subtraction(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonSqrtX.Enabled)
                labelNumber.Text = C.SqrtX(Convert.ToDouble(labelNumber.Text)).ToString();

            if (!buttonDegreeY.Enabled)
                labelNumber.Text = C.DegreeY(Convert.ToDouble(labelNumber.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }





        //кнопка Умножение
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if(CanPress())
            {
                S.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMult.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Деление
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                S.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDiv.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Сложение
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                S.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonPlus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Вычитание
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                S.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonMinus.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Корень произвольной степени
        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonSqrtX.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Возведение в произвольную степень
        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                buttonDegreeY.Enabled = false;

                labelNumber.Text = "0";
            }
        }

        //кнопка Корень квадратный
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Sqrt().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        //кнопка Квадрат числа
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(labelNumber.Text));

                labelNumber.Text = C.Square().ToString();

                C.Clear_A();
                FreeButtons();
            }
        }

        //кнопка Факториал
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) && 
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(labelNumber.Text));

                    labelNumber.Text = C.Factorial().ToString();

                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            }
        }

        //кнопка М+
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            M.M_Sum(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М-
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            M.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М*
        private void buttonMMult_Click(object sender, EventArgs e)
        {
            M.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М/
        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            M.M_Division(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка МRC
        private void buttonMRC_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                k++;

                if (k == 1)
                    labelNumber.Text = M.MemoryShow().ToString();

                if (k == 2)
                {
                    M.Memory_Clear();
                    labelNumber.Text = "0";

                    k = 0;
                }
            }
        }








        //проверяет не нажата ли еще какая-либо из кнопок мат.операций
        private bool CanPress()
        {
            if (!buttonMult.Enabled)
                return false;

            if (!buttonDiv.Enabled)
                return false;

            if (!buttonPlus.Enabled)
                return false;

            if (!buttonMinus.Enabled)
                return false;

            if (!buttonSqrtX.Enabled)
                return false;

            if (!buttonDegreeY.Enabled)
                return false;

            return true;
        }

        //снятие нажатия всех кнопок мат.операций
        private void FreeButtons()
        {
            buttonMult.Enabled = true;
            buttonDiv.Enabled = true;
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonSqrtX.Enabled = true;
            buttonDegreeY.Enabled = true;
        }



        


        

        
    }
}