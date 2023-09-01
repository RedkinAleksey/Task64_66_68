// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Не корректный ввод.");
    return;
}

int SumNaturalElements = SumNaturalNumbers(numberM, numberN);
Console.Write($"Сумма натуральных элемнтов между заданными значениями равна: {SumNaturalElements}.");

int SumNaturalNumbers(int numM, int numN)
{   
    if (numM > numN)
    {
        return numM + SumNaturalNumbers(numM - 1, numN);
    }
    else if (numM < numN)
    {
        return numM + SumNaturalNumbers(numM + 1, numN);
    }
    else
    {
        return numN;      
    }

}


