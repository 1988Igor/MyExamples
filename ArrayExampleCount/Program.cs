int[] myArray = new int [12];
Random rand  = new Random();
int i, countable, uncountable;
i = countable = uncountable = 0;

for (i = 0; i<myArray.Length; i++)
myArray[i] = rand.Next(100,150);
for (i = 0; i<myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
for (i = 0; i<myArray.Length; i++)
{


    if(myArray[i]%2==0)
    countable++;
   
     else
     uncountable++;
      
    
   }
    
   Console.WriteLine("The countable elements of array are : " + countable);
    Console.WriteLine("The uncountable elements of array are : " + uncountable);
    
