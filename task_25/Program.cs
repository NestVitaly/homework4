// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

try
    {
        Console.WriteLine("Введите число А: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B: ");
        int b = Convert.ToInt32(Console.ReadLine());
            double degree (int a, int b)
                {
                    double result = Math.Pow(a, b);
                    return result;
                }
        Console.WriteLine($"Число ({a}) в степени ({b}) = {degree(a, b)}");
    }
catch (SystemException)
    {
        Console.WriteLine("Нужно было вводить именно число");
    }
