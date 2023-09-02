// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Не корректный ввод.");
    return;
}

int ack = AckermanFunction(numberM, numberN);
Console.Write($" m = {numberM}, n = {numberN} -> A(m,n) = {ack}");

int AckermanFunction(int numM, int numN)
{   
    if (numM == 0)
    { 
        return numN + 1;
    }
    else if (numN == 0)
        {
            return AckermanFunction(numM - 1, 1);
        }
        else
        {
            return AckermanFunction((numM - 1), (AckermanFunction(numM, numN -1)));
        }
}
