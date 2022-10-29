using Algaritm;

algaritm algaritm1 = new algaritm();
Console.WriteLine("Введите число");
string digit = Console.ReadLine();
bool parse = int.TryParse(digit, out var count);
Console.WriteLine("Введите строку");
string line = Console.ReadLine();
if(parse == true)
{
    algaritm1.Func(count, line);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Ошибка");
}


