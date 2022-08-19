// задача 3
double[] arrayRealNumbers = new double[12];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 12);
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

Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
