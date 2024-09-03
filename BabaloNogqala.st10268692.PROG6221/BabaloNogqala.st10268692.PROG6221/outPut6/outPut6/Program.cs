// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter 6 Values:");

int count = 0;
while (count < 6)
{
    Console.Write($"Value {count + 1}: ");
    int value = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Entered Value: {value}");
    count++;
}

