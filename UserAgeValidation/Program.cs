// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Tere tulemast!");
}else
{
    Console.WriteLine("Sa oled liiga noor!");
}
