using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_5
{
    public class Triangle
    {
        int a; // сторона а
        int b; // сторона б
        int c; // сторона с

        // свойство а
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                // проверяем что значение больше 0
                if (value > 0) 
                {
                    a = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть больше нуля");
                }
            }
        }
        // свойство б
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                // проверяем что значение больше 0
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть больше нуля");
                }
            }
        }
        // свойство с
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                // проверяем что значение больше 0
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    MessageBox.Show("Значение должно быть больше нуля");
                }
            }
        }
        // конструктор с параметрами
        public Triangle(int valueA, int valueB, int valueC)
        {
            if (valueA > 0 && valueB > 0 && valueC > 0)
            {
                a = valueA;
                b = valueB;
                c = valueC;
            }
            else
            {
                MessageBox.Show("Значения должны быть больше нуля");
            }
        }
        // конструктор по умолчанию
        public Triangle()
        {
            a = 4;
            b = 5;
            c = 7;
        }
        // метод расчета периметра
        public int GetPerimetr()
        {
            int p = a + b + c;
            return p;
        }
        // метод задания значений
        public void SetParams(int valueA, int valueB, int valueC)
        {
            if (valueA > 0 && valueB > 0 && valueC > 0)
            {
                a = valueA;
                b = valueB;
                c = valueC;
            }
            else
            {
                MessageBox.Show("Значения должны быть больше нуля");
            }
        }
        // метод увеличения сторон в 2 раза
        public void SetParams()
        {
            // проверка что значение не превысят максимальный размер типа int
            if (a * 2 == -2147483648  || b * 2 == -2147483648 || c * 2 == -2147483648)
            {
                MessageBox.Show("При увеличении значения превысят максимальный размер типа int!");
            }
            else
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
        }
        public static bool operator true(Triangle triangle)
        {
            // проверяем существует ли треугольник
            if (triangle.A + triangle.B > triangle.C && triangle.B + triangle.C > triangle.A && triangle.A + triangle.C > triangle.B)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Triangle triangle)
        {
            return false; //???
        }
        public static Triangle operator ++(Triangle triangle)
        {
            Triangle copy = new Triangle();
            copy = triangle;
            if (copy.A + 1 == -2147483648 || copy.B + 1 == -2147483648 || copy.C + 1 == -2147483648)
            {
                MessageBox.Show("При увеличении значения превысят максимальный размер типа int!");
                return triangle; 
            }
            else
            {
                copy.A++;
                copy.B++;
                copy.C++;
            }
            return copy;
        }
        public static Triangle operator --(Triangle triangle)
        {
            Triangle copy = new Triangle();
            copy = triangle;
            if (copy.A - 1 > 0 && copy.B - 1 > 0 && copy.C - 1 > 0) 
            {
                copy.A--;
                copy.B--;
                copy.C--;

            }
            else
            {                
                MessageBox.Show("При изменении хотя бы одно значение станет равно 0");
            }
            return copy;
        }
    }
}
