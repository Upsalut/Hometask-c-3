// Подсчитать сумму цифр в числе
Console.WriteLine("Enter a number from:");
int number = int.Parse(Console.ReadLine());
int count = 0;
while (number>0)
{
    number=number/10;
    count++;
}
Console.WriteLine(count);