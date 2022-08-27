//Найти сумму чисел от 1 до А

//void Fillnumber (int number1)
//{
//int count  = 1;
//while (count<=number1)
//{


//Console.WriteLine($"{count+count+count}");
//count++;
//}

//}

//Console.WriteLine("Enter the number A :");
//int number  = int.Parse(Console.ReadLine());
//Fillnumber(number);

Console.WriteLine("Enter the number A :");
int A  = int.Parse(Console.ReadLine()?? "0");
while(A<0)
{
    Console.WriteLine("It was entered fals value, please try again");
    A  = int.Parse(Console.ReadLine()?? "0");
}
int count = 1;
int summ = 0;

while(count <= A)
{
    summ += count;
    count += 1;

}
Console.WriteLine($"Summ of number from 1 to A =  {summ} " );