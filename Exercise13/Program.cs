//---------------------------------------------------------------------------------------------------
//
// Exercise 13. Program for output 3nd digit of given number. Number must be positive and less then 100000.
// Test data:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//
bool isCorrect = false;
int num = 0;
int num_limit = 100000;
do
{
    Console.Write("Введите число: ");
    num = int.Parse(Console.ReadLine());
    isCorrect = true;
    if (num < 0) isCorrect = false;
    if (num > num_limit) isCorrect = false;
    if (isCorrect == false) {
        Console.WriteLine("Повторите ввод. Число должно быть в диапазоне 0 - {0}", num_limit);
    }
} while (isCorrect == false); 
//
string ThirdDigit = "";
if (num < 100) ThirdDigit = "третьей цифры нет";
else {
    int num3 = num;
    while (num3 > 999) num3 = num3 / 10;
    ThirdDigit = Convert.ToString(num3 % 10);
}
// Output result string
if (num > 100) Console.WriteLine("Введено число {0}, его третья цифра {1}", num, ThirdDigit);
else Console.WriteLine("Введено число {0}, {1}", num, ThirdDigit);
//