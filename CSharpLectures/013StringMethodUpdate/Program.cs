string method(int count, string text)
{
    string result = string.Empty;
    for ( int i = 0 ; i < count;i++)result = result + text;
    return result;
}

string go = method(10 , "biba ");

Console.WriteLine(go);