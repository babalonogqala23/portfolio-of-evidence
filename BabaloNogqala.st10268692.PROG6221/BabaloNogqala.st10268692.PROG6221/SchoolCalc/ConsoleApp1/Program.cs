// See https://aka.ms/new-console-template for more information



Console.Write("enter name:");
String name = Console.ReadLine();

Console.Write("enter surname:");
String surname = Console.ReadLine();

Console.Write("email:");
String email = Console.ReadLine();

Console.Write("enter student number: ");
int studentNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("enter mark 1: ");
int mark1 = Convert.ToInt32(Console.ReadLine());


Console.Write("enter mark 2: ");
int mark2 = Convert.ToInt32(Console.ReadLine());


Console.Write("enter mark 3: ");
int mark3 = Convert.ToInt32(Console.ReadLine());

Console.Write("enter exam mark: ");
int ExamMark = Convert.ToInt32(Console.ReadLine());

double DpMark;
double FinalMark;
double examCalc;
double DpMarkCalc;

DpMark = (mark1 + mark2 + mark3);
DpMarkCalc = (DpMark * 0.4);
examCalc = (ExamMark * 0.6);
FinalMark = (DpMarkCalc + examCalc );

Console.WriteLine(FinalMark);

if (FinalMark >= 0 && FinalMark <=46)
{
    Console.WriteLine("fail");
}else if(FinalMark >= 47 && FinalMark <= 49)
{
    Console.WriteLine("it's a supp");
}else if(FinalMark >=50 && FinalMark <= 74)
{
    Console.WriteLine("it's a pass");
}
else if(FinalMark >= 75 && FinalMark <=100 )
{
    Console.WriteLine("it's a distiction");
}