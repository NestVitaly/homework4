//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum(int number){
    
    int count = Convert.ToString(number).Length;
    int move = 0;
    int res = 0;

    for (int i = 0; i < count; i++){
      move = number - number % 10;
      res = res + (number - move);
      number = number / 10;
    }
   return res;
  }

int sumNumber = sum(number);
Console.WriteLine("Сумма цифр в числе: " + sum(number));