int num;
Console.WriteLine("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
int numCopy = num;
int count =0;

while(numCopy !=0)
{
    numCopy /= 10;
    count++;
}

int[] array = new int[count];
int index = 0;

while(num != 0)
{
    array[index] = num % 10;
    num /= 10;
    index++;
}
Console.Write("[");
for (int i = 0; i < 3; i++)
{
    Console.Write($"{array[i]}," );
}
Console.Write("]");