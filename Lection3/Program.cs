/*

// 1. Методы, не принимающие агрументов, не возвращающие ничего

void Method1()
{
    Console.WriteLine("Автор - Танаев И. В."); //Например, метод, который просто выводит какую-то надпись, когда его вызывают
}
Method1();

// 2. Методы, принимающие аргументы, не возвращаюшие ничего

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); //В метод направляем текст сообщения буквально, указываем аргумент, для которого мы хотим указать этот текст

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент. А если i--, то декремент.
    }
}
Method21(msg: "Текст", count: 4);

// 3. Методы, что-то возвращающие, никаких аргументов не принимающие на вход.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// 4. Методы, что-то принимающие, что-то возвращающие.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //Чтобы компьютер понимал, что строка изначально пустая
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(text: "Текст для метода 4! ", count: 10);
Console.WriteLine(res);

// Цикл for. Цикл "со счетчиком".

string ForMethod(int count, string text)
{
    string result = String.Empty; //Чтобы компьютер понимал, что строка изначально пустая
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = ForMethod(text: "Цикл for! ", count: 10);
Console.WriteLine(res);

// Цикл в цикле. Например, нужно закрасить прямоугольную область по строчкам и столбикам.
// Вывод таблицы умножения на экран.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

// Решение задач на использование методов и циклов for.

// 1. Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

string text = "Карл у Клары украл кораллы с бриллиантами."
            + "Шла Саша по шоссе";

// string s = "qwerty"
//             012345 
//s[3] // r

string ReplaceTextMethod (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = ReplaceTextMethod (text, ' ', '|');
Console.WriteLine(newText);

newText = ReplaceTextMethod (newText, 'к', 'К');
Console.WriteLine(newText);

newText = ReplaceTextMethod (newText, 'с', 'С');
Console.WriteLine(newText);

*/

// 2. Упорядочить массив.
// Алгоритм сортировки методом выбора или методом MiniMax.
// 6 8 3 2 1 4 5 7
// Выбираем первый элемент массива. В оставшейся части выбираем минимальный.
// Меняем местами выделенный элемент с найденым минимальным значением.
// Перемещаемся на следующий элемент. В оставшейся части минимальный. Меняем их местами.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArrayMethod(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArrayMethod(arr);

void MiniMaxSortMethod (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int currentPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array [j] < array [currentPosition]) currentPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[currentPosition];
        array[currentPosition] = temporary;
    }
}

PrintArrayMethod(arr);
MiniMaxSortMethod(arr);

PrintArrayMethod (arr);
