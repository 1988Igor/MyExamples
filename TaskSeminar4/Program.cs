//Задать массив, заполнить случайными положительными 
//трёхзначными числами. Показать количество нечетных\четных чисел
void FillArray(int[]array)
{
   for(int i = 0; i<array.Length; i++)
   {
      Console.WriteLine("Enter the element of array {i+1}");
      array[i] = int.Parse(Console.ReadLine()?? "0");
   }
}

void PrintArray(int[]array)
{
for(int i = 0; i<array.Length; i++)
{
   Console.WriteLine($"{array[i]}");

}


}
Console.WriteLine("Enter the length of array");
int length  = int.Parse(Console.ReadLine()?? "0");
int[] array = new int[length];

FillArray(array);
{
   int countable, uncountable;
   countable  = uncountable = 0;
for(int i = 0; i<array.Length; i++)

if (array[i]%2==0)
countable++;
else
uncountable++;
Console.WriteLine($"The number of countable digit are {countable}");
Console.WriteLine($"The number of uncountable digit are {uncountable}");

}
PrintArray(array);


//int[]array = {1, -5, -4, 6, 7, -8, 9};
//int n = array.Length;
//int index = 0;
//while(index<n)
//{

//array[index] = array[index]*-1;
//Console.Write($" {array[index]} ");
//index++;


//}

//Console.WriteLine("\n");


//int[]array = {1,5,4,6,7,8,9}
//int i = array.Length;

//for(i = 0; i<array.Length; i++)
//{
    //Console.Write($" {array[i]} ");
    //if (array[i]>0) array[i] = -array[i];
//}

//for(i = 0; i<array.Length; i++)
//{
   // Console.Write($" {array[i]} ");
//}