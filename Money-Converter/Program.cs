using Money_Converter;
using System.Diagnostics.Metrics;


void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Перевод Евро в юань");
    Console.WriteLine($"2) Превод Юань в Евро");
    Console.WriteLine($"3) Все перегрузки операторов");
    Console.WriteLine();
}
void GetMenu()
{
    while (true)
    {
        Menu();
        string enter = Console.ReadLine();
        bool convert = int.TryParse(enter, out var result);
        if (result == 1)
        {
            Console.WriteLine($"Введите число евро чтобы узнать сколько получится при переводе");
            string moneu = Console.ReadLine();
            Console.WriteLine($"Введите число юаней");
            string moneu2 = Console.ReadLine();
            bool check = int.TryParse(moneu, out var numbereuros);
            bool check2 = int.TryParse(moneu2, out var numberyuans);
            Yuan yuan1 = new() { Money = numbereuros };
            Euro yuan2 = new() { Money = numberyuans };
            Euro euro = (Euro)yuan1;
            Console.WriteLine(euro.Money);           
        }
        else if (result == 2)
        {
            Console.WriteLine($"Введите число юаней чтобы узнать сколько получится при переводе");
            string moneu = Console.ReadLine();
            Console.WriteLine($"Введите число евро");
            string moneu2 = Console.ReadLine();
            bool check = int.TryParse(moneu, out var numbereuros);
            bool check2 = int.TryParse(moneu2, out var numberyuans);
            Yuan yuan1 = new() { Money = numberyuans };
            Euro yuan2 = new() { Money = numbereuros };
            Yuan euro2 = (Yuan)yuan2;
            Console.WriteLine(euro2.Money);            
        }
        else if (result == 3)
        {
            Overloads();           
        }
        else
        {
            Console.WriteLine($"Выберите пункт из меню");            
        }
    }
}
GetMenu();
void Overloads()
{
    Console.WriteLine($"Введите первое число");
    string number1=Console.ReadLine();
    bool check1 = int.TryParse(number1, out var result1);
    Console.WriteLine($"Введите второе число");
    string number2=Console.ReadLine();
    bool check2=int.TryParse(number2, out var result2);
    var a = new MyNumber { Value = result1 };
    var b = new MyNumber { Value = result2 };
    Console.WriteLine($"Сложение {a.Value + b.Value}");
    Console.WriteLine($"Умножение{a.Value * b.Value}");
    Console.WriteLine($"Вычетание{a.Value - b.Value}");
    Console.WriteLine($"Деление{a.Value / b.Value}");
}
