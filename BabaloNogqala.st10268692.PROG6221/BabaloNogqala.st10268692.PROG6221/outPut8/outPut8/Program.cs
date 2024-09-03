// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter 8 Values:");

int count = 0;
do
{
    Console.Write($"Value {count + 1}: ");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Entered Value: {value}");
    count++;
} while (count < 8);
