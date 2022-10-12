Console.WriteLine("Провести тренировку по замене элементов текста в строке");

string Change (string text, char oldtext, char newText)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldtext) result = result + $"{newText}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "Hello World.";

string newText = Change(text, '.', '!');

Console.WriteLine(newText);
Console.WriteLine();
newText = Change(newText, ' ', '_');
Console.WriteLine(newText);
