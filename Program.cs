using CalculaterApp.Classes;

Divide divide = new Divide();
Multiply multiply = new Multiply(); 
Subtract subtract= new Subtract();
Add add= new Add();

Console.WriteLine("--------------");
Console.WriteLine("CALCULATOR APP");
Console.WriteLine("--------------");

do
{
    Console.Write("ENTER THE FIRST NUMBER:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("ENTER AN OPTION:");
    Console.WriteLine("+: ADD");
    Console.WriteLine("-: SUBTRACT");
    Console.WriteLine("*: MULTIPLY");
    Console.WriteLine("/: DIVIDE");
    string option = Console.ReadLine();

    Console.Clear();

    Console.Write("ENTER THE SECOND NUMBER:");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Clear();

    double result;



    switch (option)
    {
        case "+":
            result = num1 + num2;
            add.Calculate();
            Console.WriteLine(result);
            break;
        case "-":
            result = num1 - num2;
            subtract.Calculate();
            Console.WriteLine(result);
            break;
        case "*":
            result = num1 * num2;
            multiply.Calculate();
            Console.WriteLine(result);
            break;
        case "/":
            result = num1 / num2;
            divide.Calculate();
            Console.WriteLine(result);
            break;
        default:
            Console.WriteLine("SOMETHING WENT WRONG!");
            break;
    }
    Console.WriteLine("DO YOU WANT TO CONTINUE (Y-YES , N-NO)");
}
while (Console.ReadLine() == "Y");

Console.WriteLine("GOODBYE!");
