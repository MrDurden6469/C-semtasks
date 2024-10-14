Console.Write("введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if ( num <= 999 && num >= 100 )

{
    int FirstDigit = num / 100;
    int ThirdDigit = num % 10;

    int result = FirstDigit * 10 + ThirdDigit;

    Console.WriteLine(result);
}
else
 {
    Console.WriteLine("Некорректный ввод");
 }