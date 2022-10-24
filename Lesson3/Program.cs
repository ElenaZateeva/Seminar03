// Дан текст. Заменить в нем пробелы на знак "|", "в" на "В", "Г" на "г"
string text = "Однажды в студенную зимнюю пору "
        + "Я из лесу вышел. Был сильный мороз. "
        + "Гляжу, поднимается медленно в гору "
        + "Лошадка, везущая хворосту воз.";

// Метод замены символов
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}
    
string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

string newText1 = Replase(newText, 'в', 'В');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replase(newText1, 'Г', 'г');
Console.WriteLine(newText2);