//int[]myArray3 = {-2,-1,0,1,2,3,4,5,6,7,8,9};
//int resultNegative = myArray3[0]+myArray3[1];
//int resultPositive = myArray3[2]+myArray3[3]+myArray3[4]+myArray3[5]+myArray3[6]+myArray3[7]+myArray3[8]+myArray3[9]+myArray3[10]+myArray3[11];
//Console.WriteLine("Summ negatives elements from Array is : " + resultNegative);
//Console.WriteLine("Summ positives elements from Array is: " + resultPositive);

//for(int i = 0; i<myArray3.Length; i++)
//{
    //Console.WriteLine(myArray3[i]);
//}

int[] Numbers;
            Numbers = new int[10];

            Random rand = new Random();
            int i , positive, negative , ne, pe;

            i = positive = negative = ne= pe = 0;

            for (i = 0; i < Numbers.Length; i++)
                Numbers[i] = rand.Next(-3, 7);

            for (i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);

                if (Numbers[i] < 0)
                    ne += Numbers[i];
                if (Numbers[i] >= 0)
                    pe += Numbers[i];
               
            }
                
                Console.WriteLine();

            for (i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] >= 0)
                
                    positive++;
                else
                    negative++;
            }

            Console.WriteLine("Number of array elements > 0  = " + positive);
            Console.WriteLine("Number of array elements < 0  = " + negative );
            Console.WriteLine("The sum of negative array elements  = " + ne);
            Console.WriteLine("The sum of positive array elements  = " + pe);
            Console.ReadLine();
        
    
    