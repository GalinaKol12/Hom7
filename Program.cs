// Задача № 1

// int m = 4;
// void OneToNM(int n)
// {
// if(n > (m - 1))
// {
// OneToNM(n - 1);
// Console.Write(n + " ");
// }
// }

// OneToNM(8);


// Задача № 2

// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);

// Console.Write ($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }

// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


// Задача № 3

int[] myArray = {65, 9, 12, 36, 29}; 
 
Console.WriteLine("Элементы массива, начиная с конца:"); 
PrintArrayReverse(myArray, myArray.Length - 1);

void PrintArrayReverse(int[] arr, int i)
{
if (i >= 0)
{
    Console.Write(arr[i] + " "); 
    PrintArrayReverse(arr, i - 1);
}
}