/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue);
}  
return res;
} 

int[] array = GetArray(8, 100, 1000);
Console.WriteLine(string.Join(" ", array));
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if ( array[i]%2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);