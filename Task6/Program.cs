Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = - num; 
while(num2 <= num) 
{
Console.Write($"{num2},");
num2++;
}