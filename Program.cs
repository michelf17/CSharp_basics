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
