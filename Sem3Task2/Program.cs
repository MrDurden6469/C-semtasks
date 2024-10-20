int [] array = new int [10]{-3,-5,5,6,-7,8,-9,1,3,4};

for (int i =0; i < array.Length; i++)
{
    array[i] *= -1;
}

for (int i =0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}