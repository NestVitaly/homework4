// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры.
// Элементы тоже вводятся с клавиатуры.

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int sum(int N){
    
    int count = Convert.ToString(N).Length;
    int move = 0;
    int res = 0;

    for (int i = 0; i < count; i++){
      move = N - N % 10;
      res = res + (N - move);
      N = N / 10;
    }
   return res;
  }

int sumNumber = sum(N);
Console.WriteLine("Сумма цифр в числе: " + sum(N));