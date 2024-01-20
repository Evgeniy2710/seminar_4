// Задание 3. Совместная работа
// Семинар 4. Функции
// 20 мин
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// int[] arr = new int[9];
// int[] SumNums(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = new Random().Next(0, 8);
// }   
// return arr;
// }

//     int[] RandomArr = SumNums(arr);

// int AllNumbers(int[] arr)
// {
//     int result = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result = arr[i] + result * 10;
//         Console.WriteLine(result);
//     }
//     return result;
// }

// int nums = AllNumbers(RandomArr);

// foreach (int item in RandomArr)
// {
//     Console.Write($"{item} ");
// }

// Console.WriteLine(" ");
// Console.WriteLine(nums);

//Второй способ решения

int[] GenerateArray(int n){
Random Any = new Random();
int[] array = new int[n];
for(int i = 0; i < array.Length; i++){
array[i] = Any.Next(1, 10);
}
return array;
}
int CreateNumber(int[] array){
string number = Convert.ToString(array[0]);
for(int i = 1; i < array.Length; i++){
if(array[i] > 0){
string a = Convert.ToString(array[i]);
number = number + a;
}
}
Console.WriteLine();
int b = Convert.ToInt32(number);
return b;
}
void PrintArray(int[] array){
for(int i = 0; i < array.Length; i++){
Console.Write($"{array[i]} ");
}
}
bool w = true;
Console.Write("Пожалуйста введите число от 1 до 8: ");
int n = Convert.ToInt32(Console.ReadLine());
while(w){
if(n <= 8 && n >= 1){
w = false;

}
else{
Console.WriteLine("Не нарушайте условие!");
n = Convert.ToInt32(Console.ReadLine());
}
}
int[] array = GenerateArray(n);
PrintArray(array);
Console.WriteLine(CreateNumber(array));