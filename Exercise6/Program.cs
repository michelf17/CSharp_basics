// Exercise 6. Program for check if given number is even.
// Test data:
// 4 -> да
// -3 -> нет
// 7 -> нет
//
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
bool isEven = num % 2 == 0;
if (isEven) {
    Console.WriteLine($"Число {num} - чётное");
    }
else {
    Console.WriteLine($"Число {num} - нечётное");
}