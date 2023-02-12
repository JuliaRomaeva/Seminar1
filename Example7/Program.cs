Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 100 || num > 999){
    Console.WriteLine("Введено неправильное число");
    return;
}
int otvet = num % 10;
Console.WriteLine($"3 число: {otvet}");

