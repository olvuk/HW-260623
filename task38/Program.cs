int inputNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[] createArray(int size, int num1, int num2)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(num1, num2))/ 100 + new Random().Next(num1, num2);
    }
    return array;
}

void printArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + ".");
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
}

double findMax(double[] array) 
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double findMin(double[] array) 
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double getResult(double max, double min)
{
    double result = max - min;
    return result;
}

int size = inputNumber("Введите, пожалуйста, размер массива: ");
int minValue = inputNumber("Введите, пожалуйста, минимальное значение: ");
int maxValue = inputNumber("Введите, пожалуйста, максимальное значение: ");
double[] array = createArray(size, minValue, maxValue);
printArray(array);
Console.WriteLine();
double max = findMax(array);
Console.WriteLine("Максимальное значение в массиве - " + max);
double min = findMin(array);
Console.WriteLine("Минимальное значение в массиве - " + min);
double result = getResult(max, min);
Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве - {result:f2}");
