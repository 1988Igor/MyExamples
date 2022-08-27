//Определить количество цифр в числе
//Console.WriteLine("Enter a number");
//int number = int.Parse(Console.ReadLine());
//int i  = number;
//int count = 0;

//while(i>0)
//{
    //i = i/10;
    //count++;
//}
//Console.WriteLine($"Number of digits in  {number} is equal with {count}");

int Quantity(int number)
{
    int i = 0;
    while(number>0)
    {
        i++;
        number = number/10;
    }
    return i;
}
Console.WriteLine("Enter a number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Number of digits in  {a} is equal with {Quantity(a)}");