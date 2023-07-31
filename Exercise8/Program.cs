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