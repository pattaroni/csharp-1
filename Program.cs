using System;

namespace csharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
        }

        // завдання 2
        static void Task2()
        {
            Console.WriteLine("Завдання 2");
            Console.WriteLine("byte: " + sizeof(byte));
            Console.WriteLine("short: " + sizeof(short));
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("decimal: " + sizeof(decimal));
            Console.WriteLine("bool: " + sizeof(bool));
            Console.WriteLine("char: " + sizeof(char));
        }

        // завдання 3
        static void Task3()
        {
            Console.WriteLine("Завдання 3");
            char a = 'A';
            char b = 'Ж';
            char c = '$';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        // завдання 4
        static void Task4()
        {
            Console.WriteLine("Завдання 4");
            string name = "Oleksii";
            int age = 19;
            char symbol = 'O';
            bool isExist = true;
            string description = "student";
            double amountOfMoney = 1500.5;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(symbol);
            Console.WriteLine(isExist);
            Console.WriteLine(description);
            Console.WriteLine(amountOfMoney);
        }

        // завдання 5
        static void Task5()
        {
            Console.WriteLine("Завдання 5");
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);

            z = --x - y * 5;
            Console.WriteLine(z);

            y /= x + 5 % z;
            Console.WriteLine(y);

            z = x++ + y * 5;
            Console.WriteLine(z);

            x = y - x++ * z;
            Console.WriteLine(x);
        }

        // завдання 6
        static void Task6()
        {
            Console.WriteLine("Завдання 6");
            int a = 5, b = 6, c = 8;

            int avg1 = (a + b + c) / 3;
            Console.WriteLine(avg1);

            double avg2 = (a + b + c) / 3.0;
            Console.WriteLine(avg2);
        }

        // завдання 7
        static void Task7()
        {
            Console.WriteLine("Завдання 7");
            string firstName = "Adam";
            string lastName = "Levine";

            Console.WriteLine("Hello, {0} {1}", firstName, lastName);
            Console.WriteLine($"Hello, {firstName} {lastName}");
        }
    }
}
