using System;

namespace Exercise2
{
    public static class two
    {
        public static void Main()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            input = input.Replace("-", "");
            int sum = 0;
            bool flag = true;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = (char)input[i];
                if (symbol < 48 && symbol > 57)
                {
                    Console.WriteLine("Введенное число не целое");
                    flag = false;
                    break;
                }
                sum += symbol - '0';
            }

            if (flag)
            {
                Console.WriteLine($"Сумма цифр введенного числа: {sum}.");
            }
        }
    }
}
