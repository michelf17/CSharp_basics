//---------------------------------------------------------------------------------------------------
//
// Exercise 15. Program for input week's day number and output if it is at weekend. Input must be in range 1 - 7, where 1 - monday, 7 - sunday.
// Test data:
// 6 -> 'да'
// 7 -> 'да'
// 1 -> 'нет'
//
bool isCorrect = false;
int day = 0;
int lowlimit = 1;
int hilimit = 7;
do
{
    Console.Write("Введите индекс дня недели: ");
    day = int.Parse(Console.ReadLine());
    isCorrect = true;
    if (day < lowlimit) isCorrect = false;
    if (day > hilimit) isCorrect = false;
    if (isCorrect == false) {
        Console.WriteLine($"Повторите ввод. Номер дня недели должен быть в диапазоне {lowlimit} - {hilimit}");
    }
} while (isCorrect == false); 
//
string isWeekend = "";
if (day < 6) isWeekend = "нет";
else isWeekend = "да";
// Output result string
Console.WriteLine($"День недели №{day} - это выходной?");
Console.WriteLine("{0}", isWeekend);
//