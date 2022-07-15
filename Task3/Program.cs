//На входе функции натуральное число N, и потом формируется массив из N членов ряда Фибоначчи

Console.WriteLine("Eneter the number");
int num = Convert.ToInt32(Console.ReadLine());

string masFibonn(int arg)
{
    int[] massive = new int[arg];
    int y = 0;

    for(int x = 0; x < massive.Length; x++) 
    {
        if(x < 2)
        {
            massive[x] = y;
            y++;
        }

        else
        {
            massive[x] = massive[x-1] + massive[x-2];
        }
    }
    string mass2 = string.Join(',',massive);
    return mass2;
}

Console.WriteLine(masFibonn(num));