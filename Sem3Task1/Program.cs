//int [] array = new int[5] {3,6,7,8,9,};
int[] array = {3, 7, 6, 8, 9};
int num = 8;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
    isExistNum = true;
    break;
    }
}
//string result = isExistNum ? "Да" : "Нет";
Console.Write(isExistNum ? "Да" : "Нет");
