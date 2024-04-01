// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string GetUnderScore(string text)
{
    string target = "";

    for (int i =0; i<text.Lenght; i++)
    {
        if (char.IsUpper(i))
        {
            text += "_" + char.ToLower(c);
        }
        else
        {
            text += i;
        }
    }
    return target;
}
string name = new string (PotyretskA);
GetUnderScore(name);
System.Console.WriteLine(name);
