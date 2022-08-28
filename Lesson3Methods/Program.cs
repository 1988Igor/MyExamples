//int Method3()
//{
  //  return DateTime.Now.Year;
//}
//int Year = Method3();
//Console.WriteLine(Year);

//for(int i = 2; i<=10; i++)
//{
  //  for (int j = 2; j<=10; j++)
    //{
      //  Console.WriteLine($"{i}x{j} = {i*j}");
    //}
    //Console.WriteLine();
//}

//Replace the elements
//string Replace(string text, char oldValue, char newValue)
//{
    //string result = string.Empty;
    //int length  = text.Length;
    //for (int i = 0; i<length;i++)
    //{
       // if (text[i] == oldValue) result = result+$"{newValue}";
        //else result = result + $"{text[i]}";
    //}
    //return result;
//}
//string text = "Liebe Eltern,"

//+"aufgrund einer technischen Störung war LernSax in den letzten Tagen nicht erreichbar, "
//+"so dass ich mich erst heute mit einigen wenigen Informationen zum Schulbeginn an Sie wenden kann."
//+"Am kommenden Montag geht die Schule wieder los. Derzeit besteht keine Testpflicht und auch keine Maskenpflicht.";
//string newText = Replace(text, 'c', 'C');
//Console.WriteLine(newText);

int [] arr = {1,5,4,3,2,1,6,7};
void PrintArray(int[] array)
{
    int count = array.Length;
for(int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[]array)
{
    for (int i = 0; i < array.Length-1; i++)
    {


    int minPosition = i;

    for (int j = i+1; j < array.Length; j++)
    
{


    if (array[j]<array[minPosition])
    {
        minPosition = j;
}
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
}



}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

