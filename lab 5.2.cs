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
            //Название flag неприемлемо, так как никак не описывает зачем нужна эта переменная
            //Альтернативы: isOk, isInt

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = (char)input[i];
                if (symbol < 48 && symbol > 57)
                //Это условие никогда не сработает так как не бывает числа которое одновременно И < 48 и > 57
                //Тебе нужен был оператор ИЛИ ||
                    
                //Числа 48 и 57 это "волшебные" константы, которые не знающий человек не поймет и потратит время на изучение.
                //Символы можно сравнивать напрямую (symbol < '0' || symbol > '9')
                {
                    Console.WriteLine("Введенное число не целое");
                    flag = false;
                    break;
                }
                sum += symbol - '0'; //А здесь нет волшебной константы, это хорошо
            }

            if (flag)
            {
                Console.WriteLine($"Сумма цифр введенного числа: {sum}.");
            }
        }
    }
}
