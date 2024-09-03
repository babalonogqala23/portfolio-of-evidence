// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter 5 Values:");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Value {i + 1}: ");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Entered Value: {value}");
}
