//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Enter the number: ");
int number=int.Parse(Console.ReadLine());
int count =0;
while (count<number)
{
    int digit = count +1;
    Console.WriteLine("The squares of numbers from 1 to " + (number) + " : " + ( digit*digit ));
    count++;
}
