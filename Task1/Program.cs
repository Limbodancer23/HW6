#nullable disable
// Пользователь вводит c клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
System.Console.WriteLine("Enter number M: ");
int numM = int.Parse(Console.ReadLine());
int[] value = new int[numM];
int[] NumCount = MyArray(numM, 0);
int CountAverage = Average(NumCount, numM);
System.Console.WriteLine(String.Join(", ", value));
System.Console.WriteLine(CountAverage);

int Average(int[] ArrayCount, int size)
{
    int count =0;
    for (int i = 0; i < size; i++)
    {
        if(ArrayCount[i] > 0) count++;
    }
    return count;
}
int[] MyArray(int count, int numX)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter number {i+1}!");
        numX = Convert.ToInt32(Console.ReadLine());
        value[i] = numX;
    }
    return value;
}