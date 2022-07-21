// See https://aka.ms/new-console-template for more information

float num1;
float num2;

Console.Write("Input your first number:- ");
num1 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Input your second number:- ");
num2 = Convert.ToInt32( Console.ReadLine() );



string operant;
Console.Write("Now,type add,sub,div ,or multi : ");

operant = Console.ReadLine();

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

case "power"
}


//wait before closing
Console.ReadKey();
