// Принимает на входе число N и выдает куб чисел от 1 до N

Console.WriteLine("Введи число N");
int n=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i*i} ");
}