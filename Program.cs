/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine($"Количество чётных чисел в массиве");
int[] numbers = new int[10];
void FillArray(int[] array, int min, int max)
{
 for (int i = 0; i<array.Length; i++ )
{
 array[i] = new Random().Next(min, max);
}
}
 void WriteArray(int[] array)
{
 for (int i = 0; i<array.Length; i++ )
{
 Console.Write(array[i] + " ");
}
 Console.WriteLine();
}

int QuantityPositive(int[] array)
{
 int quantity = 0;
 for (int i = 0; i<array.Length; i++ )
{
if (array[i] % 2 == 1)
{
 quantity++;
}
}
 return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.WriteLine($"Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine($"Массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} сумма элементов = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine($"Найдите разницу ");
double[] arrayRealNumbers = new double[5];
for (int i = 0; i < arrayRealNumbers.Length; i++ )
 {
arrayRealNumbers[i] = new Random().Next(1, 5);
Console.Write(arrayRealNumbers[i] + " ");
 }
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
 for (int i = 1; i < arrayRealNumbers.Length; i++)
{
 if (maxNumber < arrayRealNumbers[i])
{
  maxNumber = arrayRealNumbers[i];
}
  if (minNumber > arrayRealNumbers[i])
{
  minNumber = arrayRealNumbers[i];
}
}
  double decision = maxNumber - minNumber;
Console.WriteLine($"\"максимальное {maxNumber} минимальное {minNumber} разница между элементами массива {decision}");

