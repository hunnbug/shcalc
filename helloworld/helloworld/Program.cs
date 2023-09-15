using System;
using System.ComponentModel;

void Main()
{
    int answer;
    string a;
    string b;
    int num1;
    int num2;

    void plus()
    {
    Schlap:
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите второе число:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            if (bt == true)
            {
                num1 = Convert.ToInt32(a);
                num2 = Convert.ToInt32(b);
                answer = num1 + num2;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void minus()
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите второе число:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            if (bt == true)
            {
                num1 = Convert.ToInt32(a);
                num2 = Convert.ToInt32(b);
                answer = num1 - num2;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void umnoj()
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите второе число:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            if (bt == true)
            {
                num1 = Convert.ToInt32(a);
                num2 = Convert.ToInt32(b);
                answer = num1 * num2;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void podeli()
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите второе число:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            num2 = Convert.ToInt32(b);
            if (bt == true && num2 != 0)
            {
                num1 = Convert.ToInt32(a);
                answer = num1 / num2;
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void stepen()
    {
        Console.WriteLine("введите первое число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите показатель степени:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            if (bt == true)
            {
                num1 = Convert.ToInt32(a);
                num2 = Convert.ToInt32(b);
                answer = (int)Math.Pow(num1, num2);
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void koren()
    {
        Console.WriteLine("введите число из которого вы хотите извлечь корень:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            num1 = Convert.ToInt32(a);
            answer = (int)Math.Sqrt(num1);
            Console.WriteLine(answer);
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void procent()
    {
        Console.WriteLine("введите число:");
        a = Console.ReadLine();
        num1 = Convert.ToInt32(a);
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            Console.WriteLine("введите процент от числа:");
            b = Console.ReadLine();
            bool bt = Int32.TryParse(b, out answer);
            num2 = Convert.ToInt32(b);
            if (bt == true && num2 != 0)
            {
                double num1 = Convert.ToDouble(a);
                double num2 = Convert.ToDouble(b);
                answer = (int)(num1 / 100 * num2);
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("error code 6");
                //сделать готу шлап
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    void factorial()
    {
        Console.WriteLine("введите число:");
        a = Console.ReadLine();
        bool at = Int32.TryParse(a, out answer);
        if (at == true)
        {
            num1 = Convert.ToInt32(a);
            for (int i = 1; i < num1; i++)
            {
                for (int j = 1; j == i; j = j * i)
                {

                }
            }
        }
        else
        {
            Console.WriteLine("error code 6");
            //сделать готу шлап
        }
    }
    factorial();
}
Main();