// See https://aka.ms/new-console-template for more information

//declare variables
float num1;
float num2;

//store input in num1 and num2
Console.Write("Input your first number:- ");
num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Input your second number:- ");
num2 = Convert.ToInt32( Console.ReadLine() );


//declare operant
string operant;
Console.Write("Now,type add,sub,div ,or multi : ");

operant = Console.ReadLine();

//select operation based on input
switch(operant)
{

case "add":
    Console.Write(num1 + num2);
    break;

case "sub":
    Console.Write(num1-num2);
    break;

case "multi":
     Console.Write(num1*num2);
     break;

     
case "div":
    Console.Write(num1 / num2);
    break;
}


//wait before closing
Console.ReadKey();
