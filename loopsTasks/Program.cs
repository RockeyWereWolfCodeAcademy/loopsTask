using System;

namespace loopsTasks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //эта часть для всех заданий одинакова | bu hisse butun tasklar ucun eynidir, Convert.ToInt32 praktikada da kecmisik
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //task 1

            //bool isPrime = true;
            //if (number == 0 || number == 1)
            //{
            //    Console.WriteLine("The number is neither prime nor compound");
            //}
            //else
            //{
            //    for (int i = 2; i <= number / 2; i++)
            //    {
            //        {
            //            if (number % i == 0)
            //            {
            //                isPrime = false;
            //                break;//то что число составное уже проверенно, пусть сразу выйдет из лупа | artiq bildik ki eded murekkebdir, loopdan cixaq
            //            }

            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine(number + " is a prime number");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " is a compound number");
            //    }
            //}
            //task 2 Точно такое же задание мы  уже  делали в  классе | sinifde hemin taski artiq elemisik
            //bool isPowerOf2 = false;
            //for (; number > 1; number /= 2)
            //{
            //    if (number % 2 == 0)
            //    {
            //        isPowerOf2 = true;
            //    }
            //    else
            //    {
            //        isPowerOf2 = false;
            //    }
            //}
            //if (isPowerOf2)
            //{
            //    Console.WriteLine("number is power of 2");
            //}
            //else
            //{
            //    Console.WriteLine("number is not power of 2");
            //}
            //task 3 без понятия что за этажи числа, скажу  количество цифр в числе(разрядов число такое же по  идее) | bele bildim ki ededin mertebeler = reqemlerin sayi
            //int numberOfDigits = 1;
            //for (; numberOfDigits >= 0; numberOfDigits++)
            //{
            //    if (number / 10 == 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        number /= 10;
            //    }
            //}
            //Console.WriteLine("Number consists of " + numberOfDigits + " digits");
        }
    }
}