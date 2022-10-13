// #Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Считываем данные пользователя
string[] ReadData(string line)
{
    Console.WriteLine(line);
    string inputLine = Console.ReadLine() ?? "0";
    string[] array = inputLine.Split(",");
    return array;
}

// Печатаем результат
void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        Console.Write(newArray[i] + ",");
    }
    Console.WriteLine(newArray[newArray.Length - 1]);
}

// Генерируем и заполняем массив
string[] GenArray(string[] newArray)
{
    string[] newArray2 = new string[newArray.Length];
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i].Length <= 3)
        {
            newArray2[count] = newArray[i];
            count++;
        }
    }
    return newArray2;
}

string[] array = ReadData("Массив: ");
string[] newArray = (array);
string[] newArray2 = GenArray(newArray);
PrintArray(newArray2);
