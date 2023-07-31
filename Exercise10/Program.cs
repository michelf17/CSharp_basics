//---------------------------------------------------------------------------------------------------
//
// Exercise 10. Program for output 2nd digit of three-digit number. Input must be correct.
// Test data:
// 456 -> 5
// 782 -> 8
// 918 -> 1
//
bool isCorrect = false;
int num = 0;
do
{
    Console.Write("Введите трёхзначное число: ");
    num = int.Parse(Console.ReadLine());
    isCorrect = true;
    if (num < 100) isCorrect = false;
    if (num > 999) isCorrect = false;
    if (isCorrect == false) {
        Console.WriteLine("Повторите ввод. Число должно быть в диапазоне 100 - 999");
    }
} while (isCorrect == false); 
//
int SecondDigit = num / 10 % 10;
// Output result string
Console.WriteLine($"Введено число {num}, его вторая цифра {SecondDigit}");
//