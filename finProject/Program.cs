
string[] ArrayMaxTextThreeLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    return newArray;
}



string[] strArray = CreateArray();

ShowArray(ArrayMaxTextThreeLength(strArray));




string[] CreateArray() 
{
  Console.Write("Напишите какой длины создаётся массив: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  Console.WriteLine("Создаём массив: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите значение {i + 1} элемента массива: ");
    array[i] = Console.ReadLine();
  }
  Console.WriteLine("Готово!");
  return array;
}

void ShowArray(string[] array) 
{
  foreach (var item in array)
    Console.Write(item + " ");
  Console.WriteLine($"Всего элементов <= 3 в массиве: {array.Length}");
}