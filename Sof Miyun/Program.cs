string number = "";
int input1 = 0;

int index = 0;
while (index<3)
{
    string input = string.Empty;

    Console.WriteLine("Please provide a number");
    input = Console.ReadLine();
    number += input;
    
    index++;
}
Console.WriteLine(number);
number = string.Empty;//""


for (int i = 0; i < 3; i++)
{
    string input = string.Empty;
    
    Console.WriteLine("Please provide a number");
    input = Console.ReadLine();
    number += input;

}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Please provide a number");
    input1 += int.Parse(Console.ReadLine());
}

Console.WriteLine(number);
Console.WriteLine(input1);
