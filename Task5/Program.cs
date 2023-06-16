Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int length = num.ToString().Length;
int result = 0;
if (length == 3){ 
    result = num % 10; 
    Console.WriteLine(result);
}
else {
    Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова.");
}

