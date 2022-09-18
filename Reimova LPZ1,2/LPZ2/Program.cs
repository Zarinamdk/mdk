using System;
namespace MDK;
class Program
{
    static void Main()
    {
        Task1();
        Console.WriteLine();
        Console.WriteLine("Задача 2");
        int a = Convert.ToInt32(Console.ReadLine());
        Task2(a);
        Console.WriteLine();
        Task3();
        
        Console.ReadKey();
    }
    static void Task1()
    {
        Console.WriteLine("Задача 1");
        int number;

        while (true)
        {
            Console.WriteLine("Введите число от 1 до 7");
            bool isNumber = false;
            isNumber = int.TryParse(Console.ReadLine(), out number);
            if (isNumber == true)
            {
                if (number >= 1 && number <= 7)
                {
                    break;
                }
                else
                    Console.WriteLine("Число за пределами диапазона");
            }
            else
                Console.WriteLine("Введено не число");
        }
        string day = "";
        switch (number)
        {
            case 1:
                day = "понедельник";
                break;
            case 2:
                day = "вторник";
                break;
            case 3:
                day = "среда";
                break;
            case 4:
                day = "четверг";
                break;
            case 5:
                day = "пятница";
                break;
            case 6:
                day = "суббота";
                break;
            case 7:
                day = "воскресенье";
                break;
        }
        Console.WriteLine(day);

    }
    static void Task2(int number1)
    {
        if (number1 % 3==0 && number1 % 5 == 0) 
        {
            Console.WriteLine("BuzzFizz");
        }
        else 
        if (number1%5 ==0)
        {
            Console.WriteLine("Fizz");
        }
        else
        if (number1 % 3 == 0)
        {
            Console.WriteLine("Buzz");
        }

    }
    static void Task3()
    {
        Console.WriteLine("Задача 3");
        Console.WriteLine("Введите первое число");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите действие");
        string act = Console.ReadLine();
        double result = 0;
        
        switch (act)
        {
            case "+":
                result = number1+number2;
                break;
            case "-":
                result = number1-number2;
                break;
            case "*":
                result = number1*number2;
                break;
            case "/":
                result = number1/number2;
                break;
        }
        Console.WriteLine("Результат");
        Console.WriteLine($"{number1} {act} {number2} = {result}");
    }
}
