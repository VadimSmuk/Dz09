

////////////////    1

// Console.Write("Введите первое число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void ShowNumbers(int M, int N)
// {
//     if (M == N)
//     {
//         Console.WriteLine(M);
//         return; //ломает всю программу
//     }
//     Console.Write(M + " ");
//     ShowNumbers(M + 1, N);
// }
// ShowNumbers(M, N);

////////////////    2

// static class Program
// {
// static void Main()
// {
// Console.WriteLine("Введите первое число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int result = AckerFunction(m, n);
// Console.WriteLine("Результат: " + result);
// Console.ReadLine();
// }
// static int AckerFunction(int m, int n, int result = 0)
// {
//     if (m == 0)
//         return result + n + 1;
//     else if (m > 0 && n == 0)
//         return AckerFunction(m - 1, 1, result);
//     else
//         return AckerFunction(m, n - 1, AckerFunction(m - 1, n, result));
// }
// }


//////////////  3

//     class Program
//     {
//     static void Main(string[] args)
//     {
//         int[] array = { 1, 2, 3, 4, 5 };
//         PrintArrayReversed(array, array.Length - 1);
//         Console.ReadLine();
//     }
    
//     static void PrintArrayReversed(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintArrayReversed(array, index - 1);
//         }
//     }
// }


