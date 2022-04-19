void CreateInfo(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(0, 2);
    }
}

void CreateData(int[] mass,int len)
{
    int sum = 0;
    while(sum != len)
    {
        Console.WriteLine("Введите значения для массива data.");
        Console.WriteLine("Сумма элементов массива data должна быть равна количеству элементов массива info");
        for(int i = 0; i < mass.Length; i++)
        {
            Console.Write($"Введите значение {i}: ");
            mass[i] = Convert.ToInt32(Console.ReadLine());
            sum += mass[i];
        }
        if(sum > len || sum < len)
        {
            Console.WriteLine("Вы ввели значения сумма которых не равна количеству элементов массива info");
            Console.WriteLine("Попробуйте ещё раз!");
            sum = 0;
        }
        else if(sum == len)
        {
            break;
        }
    }
}

void Znach(int[] mass1, int[] mass2)
{
    int sum = 0;
    for(int i = 0; i < mass2.Length; i++)
    {
        for(int j = 0; j < mass2[i]; j++)
        {
            sum = mass1[mass2[i] - 1 + j] * 2;
        }
    }
}

Console.Write("введите длину массива info: ");
int lenInfo = Convert.ToInt32(Console.ReadLine());
Console.Write("введите длину массива data (Длина может быть меньше, но не больше массисва info): ");
int lenData = Convert.ToInt32(Console.ReadLine());

int[] info = new int[lenInfo];
int[] data = new int[lenData];

CreateInfo(info);
CreateData(data, lenInfo);

for(int i = 0; i < info.Length; i++)
{
    Console.Write(info[i] + "; ");
}

Console.WriteLine();

for(int j = 0; j < data.Length; j++)
{
    Console.Write(data[j] + "; ");
}
