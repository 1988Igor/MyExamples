//Задать массив, заполнить случайными положительными 
//трёхзначными числами. Показать количество нечетных\четных чисел


void FillArray(int[] array )
{
int[] array= new int [12];
Random rand = new Random();

}

void PrintArray(int[]array)
{
    for (int i = 0; i<array.Length; i++)
    array[i] = rand.Next(100,150);
for (i = 0; i<array.Length; i++)
{
    Console.WriteLine(array[i]);
}
}
void Countable_Uncountable(int countable, int uncountable)
{
for (i = 0; i<array.Length; i++)



    if(array[i]%2==0)
    countable++;
   
     else
     uncountable++;
      
    Console.WriteLine("The countable elements of array are : " + countable);
    Console.WriteLine("The uncountable elements of array are : " + uncountable);
   }

FillArray();
PrintArray();
Countable_Uncountable();

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


//int[]array = {1,5,4,6,7,8,9};
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