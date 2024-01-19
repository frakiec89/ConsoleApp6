// nocopy
using ConsoleApp6;
// ***************** -- таким кодом  пометил  вызов методов - будьте  внимательны, реализуйте  сначала  методы, потом  вызывайте 

Console.WriteLine("Камень //   ножницы // бумага //");    // приветствии 
PrintYellow ( GameLogic.Help()  /*******************/);     // правила   *****************

while (true)  // повторения
{
   StartGame (); // вызов раунда *****************
}

void StartGame()
{
    PrintYellow("Введите ваш вариант");  // печатаем  желтым 
    try
    {
        string variant = Console.ReadLine(); 
        string result = GameLogic.IsWin(variant); // *****************
        PrintGreen(result); // Выведем результат  игры зеленым   *****************
    }
    catch (Exception ex) // если ошибка
    {
        PrintRed(ex.Message); // печатаем  красным  *****************
    }
  
}


// Цвета  для консоли

void PrintGreen(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомним цвет
    Console.ForegroundColor = ConsoleColor.Green; // поставим зеленый  
    Console.WriteLine(message);                   // выведем сообщение
    Console.ForegroundColor = color;              // вернем цвет
}

void PrintRed(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомним цвет
    Console.ForegroundColor = ConsoleColor.Red; // поставим красный 
    Console.WriteLine(message);                   // выведем сообщение
    Console.ForegroundColor = color;              // вернем цвет
}

void PrintYellow(string message)
{
    ConsoleColor color = Console.ForegroundColor; // запомним цвет
    Console.ForegroundColor = ConsoleColor.Yellow; // поставим жёлтый 
    Console.WriteLine(message);                   // выведем сообщение
    Console.ForegroundColor = color;              // вернем цвет
}