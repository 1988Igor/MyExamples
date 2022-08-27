double firstvalue, secondvalue;
string action;
 
 Console.WriteLine("Enter the first number :");
 firstvalue = double.Parse(Console.ReadLine());
 Console.WriteLine("Enter the second number :");
 secondvalue = double.Parse(Console.ReadLine());
 Console.WriteLine("Chose a symbol : '+', '-', '*' ");
 action = Console.ReadLine();

 switch(action)
 {

    case "+":
        Console.WriteLine(firstvalue+secondvalue);
        break;

    case "-":
    Console.WriteLine(firstvalue-secondvalue);
    break;

    case "*":
    Console.WriteLine(firstvalue*secondvalue);
    break;
    default:
    Console.WriteLine("Wrong symbol, please try again!");
    break;

 }