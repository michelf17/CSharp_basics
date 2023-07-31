//
// Exercise 1. Program for check if first given number is square of a second given number.
//
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int sqr2 = Convert.ToInt32(Math.Pow(num2, 2));
//
bool isSquare = num1 == sqr2;
if (isSquare) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}
//---------------------------------------------------------------------------------------------------
