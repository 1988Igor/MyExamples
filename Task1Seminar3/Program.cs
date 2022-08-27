void Fillnumber (int number1)
{
int count  = 1;
while (count<=number1)
{


Console.WriteLine($"{count}*{count} = {count*count}");
count++;
}

}

Console.WriteLine("Enter the number N :");
int number  = int.Parse(Console.ReadLine());
Fillnumber(number);