// Найти расстоние мужду 2мя точками в 3D пространстве

Console.WriteLine("Введите координаты 1й точки");
bool isParsedXA=int.TryParse(Console.ReadLine(), out int XA);
bool isParsedYA=int.TryParse(Console.ReadLine(), out int YA);
bool isParsedZA=int.TryParse(Console.ReadLine(), out int ZA);

Console.WriteLine("Введите координаты 2й точки");
bool isParsedXB=int.TryParse(Console.ReadLine(), out int XB);
bool isParsedYB=int.TryParse(Console.ReadLine(), out int YB);
bool isParsedZB=int.TryParse(Console.ReadLine(), out int ZB);

if (!isParsedXA || !isParsedYA || !isParsedXB || !isParsedYB 
                || !isParsedZA || !isParsedZB)

{ 
    Console.WriteLine("Ошибка! Неправильно введены координаты.");
    return;
}

double distanceDot=Distance(XA, YA, XB, YB, ZA, ZB);
Console.WriteLine($"Растояние между точками  {distanceDot}");

double Distance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    double dis=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+ (z2-z1)*(z2-z1));
    return dis;
}
