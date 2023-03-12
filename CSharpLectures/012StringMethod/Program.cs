
string method(int count, string text)
{
    int i=0;
    string result = string.Empty;
    while (i< count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string go = method(10 , "biba ");

Console.WriteLine(go);