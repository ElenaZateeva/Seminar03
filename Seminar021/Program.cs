// Найти расстоние мужду 2мя точками в 2D пространстве

Console.WriteLine("Введите координаты 1й точки");
bool isParsedXA=int.TryParse(Console.ReadLine(), out int XA);
bool isParsedYA=int.TryParse(Console.ReadLine(), out int YA);

Console.WriteLine("Введите координаты 2й точки");
bool isParsedXB=int.TryParse(Console.ReadLine(), out int XB);
bool isParsedYB=int.TryParse(Console.ReadLine(), out int YB);

if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB)
{ 
    Console.WriteLine("Ошибка! Неправильно введены координаты.");
    return;
}

double distanceDot=Distance(XA, YA, XB, YB);
Console.WriteLine($"Растояние между точками  {distanceDot}");

double Distance(int x1, int y1, int x2, int y2)
{
    double dis=Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return dis;
}