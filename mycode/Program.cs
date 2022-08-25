int[]myArray = new int[12];
Random rand = new Random();
int i, positive, negative, po, ne;
i = positive=negative  = po = ne = 0;

    for(i=0;i<myArray.Length; i++)
    myArray[i] = rand.Next(-2,9);

    for(i=0;i<myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
    
    if (myArray[i]>=0)
    po+=myArray[i];

    if (myArray[i]<0)
    ne+=myArray[i];
   
}

    for(i = 0; i < myArray.Length; i++)
    {
        if (myArray[i]>=0)
        positive++;

        else
        negative++;
    }



    Console.WriteLine("The positive elements of array are :" + positive);
    Console.WriteLine("The negative elements of array are :" + negative);
    
    Console.WriteLine("The sum of positive elements of array is " + po );
    Console.WriteLine("The sum of negative elements of array is " + ne );
    
