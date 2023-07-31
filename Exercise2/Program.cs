// Exercise 2. Program for find maximum of two given numbers
// Test data:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int num_max = a;
if (b > a) {
    num_max = b;
    }
// Output result data
Console.WriteLine($"Наибольшее число из {a}, {b} равно {num_max}");