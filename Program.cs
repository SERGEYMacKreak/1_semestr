
int N = 3; // ограничитель.

Console.Write("Сколько строк будет в массиве?: ");
int longArrey = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
string[] arreyA = new string[longArrey]; //значение которое ввел пользователь является длинной массива

for (int i = 0; i < longArrey; i++)// с помощью цикла for заполняем массив.
  {
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    arreyA[i] = Console.ReadLine(); 
  }

Console.WriteLine();

for (int i = 0; i < arreyA.Count(); i++)// с помощью цикла for проверяем длину каждого элемента массива и если он меньше 4 выводим его.
{
  if (arreyA[i].Length <= N)
  {
    Console.Write($"~{arreyA[i]}~, ");
  }
}
Console.Write("- строки длина которых меньше, либо равна 3 символам.");