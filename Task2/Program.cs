// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int B1Number = EnterB1Number("Enter B1: ");
int K1Number = EnterK1Number("Enter K1: ");
int B2Number = EnterB2Number("Enter B2: ");
int K2Number = EnterK2Number("Enter K2: ");
int[] FirstArray = Array1(2, K1Number, B1Number);
int[] SecondArray = Array2(2, K2Number, B2Number);
double ResultX = sumArr(2, FirstArray, SecondArray);

System.Console.WriteLine(ResultX);

double sumArr(int size, int[] First, int[] Second)
{
    double ResultY;
    double result = 0;
    double[] value = new double[size];
    for (int i = 0; i < size; i++)
    {
        value[i] = First[i] - Second[i];
    }
    value[1]*=-1;
    result = value[1] / value[0];
    ResultY = K2Number * result + B2Number;
    System.Console.WriteLine(ResultY);
    return Math.Round(result, 2);
}

int[] Array1(int size, int num1, int num2)
{
    int[] value = new int[size];
    value[0] = num1;
    value[1] = num2;
    return value;
}

int[] Array2(int size, int num1, int num2)
{
    int[] value = new int[size];
    value[0] = num1;
    value[1] = num2;
    return value;
}

int EnterB1Number(string number)
{
    Console.WriteLine(number);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int EnterK1Number(string number)
{
    Console.WriteLine(number);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int EnterB2Number(string number)
{
    Console.WriteLine(number);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int EnterK2Number(string number)
{
    Console.WriteLine(number);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}