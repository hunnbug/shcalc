using System;
using System.ComponentModel;
int answer;
string a;
string b;
int num1;
int num2;

Console.WriteLine("шкалькулятор v f.01, нажмите любую клавишу для продолжения");
Console.ReadKey();
start();

void start()
{
    string deystv;
    int deystvnum;
    do
    {
        Console.WriteLine("\nвыберите действие из списка, написав соответствующую цифру: \n1. сложение \n2. вычитание \n3. умножение \n4. деление  \n5. возведение в степень \n6. нахождение квадратного корня \n7. нахождение 1 процента от числа \n8. нахождение факториала из числа \n9. выход");
        deystv = Console.ReadLine();
        deystvnum = Convert.ToInt32(deystv);
        if (deystvnum == 1)
        {
            plus();
        }
        else if (deystvnum == 2)
        {
            minus();
        }
        else if (deystvnum == 3)
        {
            umnoj();
        }
        else if (deystvnum == 4)
        {
            podeli();
        }
        else if (deystvnum == 5)
        {
            stepen();
        }
        else if (deystvnum == 6)
        {
            koren();
        }
        else if (deystvnum == 7)
        {
            procent();
        }
        else if (deystvnum == 8)
        {
            factorial();
        }
    } while (deystvnum != 9);
}
void plus()
{
    try
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        Console.WriteLine("введите второе число:");
        b = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        num2 = Convert.ToInt32(b);
        answer = num1 + num2;

        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}
void minus()
{
    try
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        Console.WriteLine("введите второе число:");
        b = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        num2 = Convert.ToInt32(b);
        answer = num1 - num2;
        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}
void umnoj()
{
    try
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        Console.WriteLine("введите второе число:");
        b = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        num2 = Convert.ToInt32(b);
        answer = num1 * num2;
        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}
void podeli()
{
    try
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        Console.WriteLine("введите второе число:");
        b = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        num2 = Convert.ToInt32(b);
        if (num2 != 0)
        {
            answer = num1 / num2;
            Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
        }
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа(не ноль)\n");
        start();
    }
}
void stepen()
{
    try
    {
        Console.WriteLine("введите число:");
        a = Console.ReadLine();
        Console.WriteLine("введите показатель степени:");
        b = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        num2 = Convert.ToInt32(b);
        answer = (int)Math.Pow(num1, num2);
        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }

}
void koren()
{
    try
    {
        Console.WriteLine("введите число");
        a = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        double answer = Math.Sqrt(num1);
        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}
void procent()
{
    try
    {
        Console.WriteLine("введите число:");
        a = Console.ReadLine();


        double num1 = Convert.ToDouble(a);
        double answer = num1 / 100;
        Console.WriteLine("Ваш ответ: \n" + answer + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}
void factorial()
{
    try
    {
        int fact = 1;
        Console.WriteLine("введите число:");
        a = Console.ReadLine();


        num1 = Convert.ToInt32(a);
        for (int i = 1; i <= num1; i++)
        {
            fact *= i;
        }
        Console.WriteLine("Ваш ответ: \n" + fact + "\n----------------");
    }
    catch
    {
        Console.WriteLine("\nтак нельзя, вводите числа\n");
        start();
    }
}