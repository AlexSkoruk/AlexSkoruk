using Calculator;
using TraversingTheArray;

    task2();


void task1()
{
    Console.Write("Введите размерность массива --> ");
    int n = Convert.ToInt32(Console.ReadLine());


    double[] mas = new double[n];
    for (int i = 0; i < n; i++)
    {
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"Минимальное значение: {ExtensionMethods.FindMinimum(mas)}");
    Console.WriteLine($"Максимальное значение: {ExtensionMethods.FindMaximum(mas)}");
    Console.WriteLine($"Медиана: {ExtensionMethods.FindMedian(mas)}");
    Console.WriteLine($"Среднее арифметическое: {ExtensionMethods.FindAverage(mas)}");
    Console.WriteLine($"Среднее геометриеское: {ExtensionMethods.FindGeometricAverage(mas)}");

}

void task2()
{
    Console.Write("Введите арифметическое выражение --> ");
    string a = Console.ReadLine();
    Console.WriteLine($"Ответ: {MathematicalOperations.Score(a)}");
}

