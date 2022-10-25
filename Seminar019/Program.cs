// На входе 5-ти значное число. Проверяем: является ли оно полидромом?

Console.WriteLine("Введите 5-ти значное число");
bool isParsedNum = int.TryParse(Console.ReadLine(), out int numer);
if (!isParsedNum || numer > 99999 || numer < 10000)
{
    Console.WriteLine("Ошибка! Ввели неверное число.");
    return;
}
// Переводим число в массив
var nToStr = numer.ToString();
int[] n = new int[nToStr.Length];
for (int i = 0; i < nToStr.Length; i++)
{
    n[i] = (int)char.GetNumericValue(nToStr[i]);
}

// Проверка на палиндром
int pos = 0;
for (int i = 0; i < nToStr.Length / 2; i++)
{
    if (!(n[i] == n[nToStr.Length - i - 1]))
    {
        Console.WriteLine("Данное число не является палиндромом");
        break;
    }
    else pos = i;
}
if (pos == nToStr.Length / 2 - 1)
    Console.WriteLine("Данное число ПАЛИНДРОМ");
