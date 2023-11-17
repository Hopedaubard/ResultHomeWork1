// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Main();

void Main()
{
    string[] sourceArray = new string[] { "Thomas", "Block", "Younger", "In", "Da", "House", "Go", "Red", "Holy", "Motors" };
    int countArrayElem = GetCountStringArrayElem(sourceArray);
    string[] resultArray = new string[countArrayElem];
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            string temp = sourceArray[i];
            resultArray[resultArray.Length - countArrayElem] = temp;
            countArrayElem--;
        }
    }
    PrintArray(sourceArray);
    PrintArray(resultArray);
}

int GetCountStringArrayElem(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(string[] source)
{
    string result = string.Join(", ", source);
    Console.WriteLine($"[{result}]");
}