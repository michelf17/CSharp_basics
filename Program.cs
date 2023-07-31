/*
//
// Program for calculation square of a given number.
//

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// Mathematical method
int Square = number * number;
Console.WriteLine($"Квадрат числа {number} равен {Square}");

// Library method
int square2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} равен {square2}");
*/
//---------------------------------------------------------------------------------------------------
/*
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
*/
//---------------------------------------------------------------------------------------------------
/*
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
*/
//---------------------------------------------------------------------------------------------------
/*
// Exercise 4. Program for find maximum of three given numbers
// Test data:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());

int num_max = num1;
if (num2 > num_max) {
    num_max = num2;
    }
if (num3 > num_max) {
    num_max = num3;
}
// Output result data
Console.WriteLine($"Наибольшее число из {num1}, {num2}, {num3} равно {num_max}");
*/
//---------------------------------------------------------------------------------------------------
/*
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
*/
//---------------------------------------------------------------------------------------------------
//
// Exercise 8. Program for printing all even numbers from 1 to given number.
// Test data:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
//
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
bool isEven = num % 2 == 0;
int i = 2;
while (i <= num){
    Console.Write(i + " ");
    i += 2;
}
Console.WriteLine("");
//
i = 2;
string cEvenNums = "";
while (i <= num){
    cEvenNums += Convert.ToString(i) + " "; 
    i += 2;
}
// Output result string
Console.WriteLine("" + cEvenNums);
//