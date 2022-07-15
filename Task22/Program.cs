//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Eneter the number");
int num = Convert.ToInt32(Console.ReadLine());

void findQuar(int arg)
{
    int y = 1;
    int a = 0;

    while(y <= arg)
    {
        a = y * y;
        y++;
        Console.Write(a);
        Console.Write(", ");
    }
}

findQuar(num);