/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
//int nDay = Convert.ToInt32(Console.ReadLine()); // 
int nDay = int.Parse(Console.ReadLine());//строка в число

if (nDay==1)
{
Console.WriteLine($"{nDay}->Понедельник");
}
else if (nDay==2)
{
Console.WriteLine($"{nDay}->Вторник");
}
else if (nDay==3)
{
Console.WriteLine($"{nDay}->Среда");
}
else if (nDay==4)
{
Console.WriteLine($"{nDay}->Четверг");
}
else if (nDay==5)
{
Console.WriteLine($"{nDay}->Пятница");
}
else if (nDay==6)
{
Console.WriteLine($"{nDay}->Суббота");
}
else if (nDay==7)
{
Console.WriteLine($"{nDay}->Воскресенье");
}
else
{
Console.WriteLine("Сколько дней в неделе?");
}
