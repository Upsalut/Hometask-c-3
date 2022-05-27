//Найти сумму чисел от 1 до А
Console.WriteLine("Enter the number: ");
int number=int.Parse(Console.ReadLine());
int count =0;
int digit =0;
while (count<=number)
{
    digit=digit+count;
    count++;
}
Console.WriteLine(digit);