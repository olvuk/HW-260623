int inputNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] createArray(int size, int num1, int num2)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(num1, num2 + 1);
    }
    return array;
}

void printArray(int[] array)
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

int getSum(int[] array) 
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int size = inputNumber("Введите, пожалуйста, размер массива: ");
int minValue = inputNumber("Введите, пожалуйста, минимальное значение: ");
int maxValue = inputNumber("Введите, пожалуйста, максимальное значение: ");
int[] array = createArray(size, minValue, maxValue);
printArray(array);
Console.WriteLine();
int sum = getSum(array);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях - " + sum);
