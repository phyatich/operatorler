using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            int a = 3;
            int b = 4;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);

            int num1 = 10;
            int num2 = 5;
            int result1 = num1 / num2;
            Console.WriteLine(result1);
            result1 = num1 * num2;
            Console.WriteLine(result1);
            result1 = num1 + num2;
            Console.WriteLine(result1);
            result1 = num1++;
            Console.WriteLine(result1);

            int result2 = 20 % 3;
            Console.WriteLine(result2);
        }
    }
}
