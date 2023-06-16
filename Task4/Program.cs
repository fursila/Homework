Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int counter = 1;
while (n >= counter) 
 {
    if (counter % 2 == 0) 
    {
        Console.Write(counter + " ");
    }
    counter ++;
}