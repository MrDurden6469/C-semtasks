Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 1000 && num >= 100)
{
int SecondDigit = num / 10 % 10;
int ThirdDigit = num % 10;
int result = SecondDigit;
int counter = 1;

while (counter <= ThirdDigit)
{
    result = result * SecondDigit;
    counter++;
}

Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Некорректный ввод!");
}