// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Enter five digit number and I will inform you if it's a palindrome number");
int a = Convert.ToInt32(Console.ReadLine());
string aStr = Convert.ToString(a);
if (a >= 10000 && a < 100000)
{
    if(aStr[0] == aStr[4] && aStr[1] == aStr[3])
{
    Console.WriteLine("This is palindrome number");
}
else
{
    Console.WriteLine("This is not palindrome number");
}
}