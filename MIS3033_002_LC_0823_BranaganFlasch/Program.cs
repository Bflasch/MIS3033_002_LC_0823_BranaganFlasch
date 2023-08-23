// MIS 3033 002
//August 23, 2023
// Branagan Flasch, 113515518
// simple: int double bool char, not expensive
// complex: expensive

using System.Globalization;

int age1; //simple 
string str1; //complex

str1= new string("MIS3033");
age1 = 20;

string str2;
// new string("MIS3013");
str2 = "mis 3013";

// operators, expression
double r1;
r1 = 100 % 2;
Console.WriteLine(r1);

//comparison 
bool r2;
r2 = 3 >= 2;

r2 = 3 == 2;

r2 = !(3 == 2);
Console.WriteLine(r2);
// ! means NOT 
// && AND
// || means OR 

// = (assignment operator)
// functions
//simple ve complex

//constant 
const int age2 = 20;

//
string str3;
Console.WriteLine("Input the grade");
str3 =Console.ReadLine();
// string answer= Console.ReadLine();

int age4; // int16 long int 64 -  regular int is assumed 32 
// 6666666666
// 6666
double grade1;
grade1 = Convert.ToDouble(str3);

// string.format()
Console.WriteLine(grade1);

String outMes;
outMes = string.Format($"The grade is {grade1:F3}");
Console.WriteLine(outMes);

if (grade1>=90)
{
    Console.WriteLine("You got an A!");
}
else
{
    Console.WriteLine("NOT A");
}


if (grade1 >= 90)
{
    Console.WriteLine("You got an A!");
}
else if (grade1 >= 80)
{
    Console.WriteLine("B");
}
else if (grade1 >= 70)
{
    Console.WriteLine("C");
}
else 
{
    Console.WriteLine("You failed");
}


//loop
//for 
// break : stop the loop 
// continue : 
for(int i = 1; i <= 100; i= i+1) // i++
{
    if (i== 13 || i== 15 || i ==17)
    {
        continue;
    }
    Console.WriteLine(i);
    if (i >= 20)
    {
        break; // stop the loop
    }
}

//while () {}

int i2;
i2 = 1;
while(i2<=20)
{
Console.WriteLine(i2);
    i2 = i2 + 1;
}

do
{
    Console.WriteLine(i2);
    i2 = i2 + 1;
}
while (i2 <= 20);