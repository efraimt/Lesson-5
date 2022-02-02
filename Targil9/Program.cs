

int number = 0;
int input = 1;

bool isFirstIeration = true;
while (input > 0)
{
    input = int.Parse(Console.ReadLine());
    if (input < number && input > 0 || isFirstIeration)
        number = input;

    isFirstIeration = false;
}
Console.WriteLine("The numer is:" + number);
