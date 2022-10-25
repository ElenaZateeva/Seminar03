// Программа на входе получает координаты (x,y), при чем x<>0 и y<>0. 
// На выходе выдает возможные значения координат плоскости.
Console.WriteLine("Введите по очереди координаты точки А x и y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int numberOfQuarter = DetermineNumberOfQuarter(x, y);
string stroka = CoordinateOfQuarter(numberOfQuarter);
Console.WriteLine(stroka);

string CoordinateOfQuarter(int q)
{
    switch (q)
    {
        case 1:
            return "x>0 и y>0";
        case 2:
            return "x<0 и y>0";
        case 3:
            return "x<0 и y<0";
        case 4:
            return "x>0 и y<0";
        default:
            return "Ошибка! Не правильно задана четверть.";
    }

}

int DetermineNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return -1;
}
