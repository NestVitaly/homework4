// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. N - вводится с клавиатуры.
// Элементы тоже вводятся с клавиатуры.

Console.Write("Введите количество элементов массива: ");
int array = Convert.ToInt32(Console.ReadLine());
int [] elements = new int [array];
ArrayElements(elements);
ElementsArray(elements);

void ArrayElements(int[] numbers)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{i}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void ElementsArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "; ");
    }
    Console.Write("]");
    Console.WriteLine();
}