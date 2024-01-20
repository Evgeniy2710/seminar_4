//для начала надо задать комманду, которая на вход будет принимать размерность массива
Console.WriteLine($"Введите размер массива:" );
int n = Convert.ToInt32(Console.ReadLine());
//  Задайте массив из N случайных чисел(N вводится с клавиатуры)
int[] GenerateArray(int n){
    int[] array = new int[n]; //задаем пустой массив размерностью n
    
    for(int i = 0; i < n; i++){
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

// Теперь нужно сделать функцию определяющую, окончивается ли число на 1.
bool EndWithOne(int n)
{
    if (n % 10 == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Теперь сделаем функцию, которая проверяет делимость числа на 7.
bool DelitsaNa7(int n)
{
    if (n % 7 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//теперь нужно сделать условие при котором проверяется подходит ли число
// заодно лучше сделать функцию на вывод массива

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}



//Теперь осталось сделать функцию, которая будет персчитывать элементы массива и проверять соответствие условию.
int TrueOrFalse(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (EndWithOne(array[i]) && DelitsaNa7(array[i]))
        {
            count++;
        }
    }
    return count;
}

int[] array = GenerateArray(n);
int a = TrueOrFalse(array);
PrintArray(array);
Console.WriteLine(a);

