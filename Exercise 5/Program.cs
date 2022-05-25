//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Enter the number: ");
int number=int.Parse(Console.ReadLine());
int count =0;
while (count<number)
{
    int digit = count +1;
    int digitCubed = digit*digit*digit;
    if (digitCubed%2==0)
    {
Console.WriteLine(digitCubed+ " ");
    }
    count++;
}
