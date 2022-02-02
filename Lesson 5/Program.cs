
int yoya = 32;
string message = "Some very smart message...";
double average = 60.2135487;
bool areYouFellingGoodToday = true;

bool areYouHappyToday = areYouFellingGoodToday && true;
int age = yoya + int.Parse(Console.ReadLine()) * 3;

Console.WriteLine(age);
Console.WriteLine(32 + 561 / 8);
Console.WriteLine((32 + 561) / 8); // (not :) ! same as the line above

string chain = message + " " + "another message ";
chain += "end of mesasages";

average += 11.25;
//average = average + 11.25; // same as above
average++;
average += 1;

/* math operators
 =
 +
-
 /
*
*=
/=
+=
-=
++
--
 */

//implicit conversions - בצורה נעלמת, מאחורי הקלעים
//explicit conversions - מפורש

message += "52.5" + 63.1 + 21;

string str1 = (50).ToString() + ""; //The ToString is redundent
string str2 = yoya.ToString() + "";

double dbl = int.Parse(Console.ReadLine());
double dbl1 = int.Parse("612000");

int x1 = (int)dbl1;
int y1 = Convert.ToInt32(dbl1);


//int.Parse("Shalom"); // Exception
//double dbl2 = int.Parse("612000.002"); // Exception - same as above line

int result = 40 / 4; //10
int reminder = 40 % 4; // 0

result /= 3;//3
reminder %= 4;

reminder = 19 % 7; //5

for (int i = -10; i < 11; i++)
{
    if (i % 2 == 0 || i == 5)
        Console.WriteLine(i);
}



/*{ Bolean operators
==
>
>=
<
<=
!=
}
*/


bool b1 = true;
int i1 = 12;

bool b2 = b1 && i1 > 30; //false - exactly as the line below
b2 = b1 && (i1 > 45);

if (b2) ;
if (true) { }
if (b1 && i1 > 30) { }

/********************************/
int index = 0;
while (index <= 10)
{
    if (index == 10)
        Console.WriteLine(index);
    index = index * 76 / 96;
}
Console.WriteLine(index);

int i5;
int res = 5;
for (int i=1; i<=10; i++,res+=7)
{
     res = 65;
    res += 12;
}
//res = 4; we don't have a res variable in the current context

for (int i = 0; i < 100; i++) // We can use i in this scop, also we have i in previous line in child scopes of main
{

}

















