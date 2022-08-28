/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] array = GetArray(8, 0, 500);
Console.WriteLine(string.Join(" ", array));
int min = array[0]; 
int max = array[0];
int diff = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if ( array[i] < min )
    {
        min = array[i];
    }
}
diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементом {diff}");



int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        {
        res[i] = new Random().Next(minValue, maxValue);
        }  
    return res;
} 

