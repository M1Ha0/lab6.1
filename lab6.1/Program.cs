Random random = new Random();
int[,] mas = new int[4, 4];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(1, 16);
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (i > j)
        {
            mas[i, j] = 0;
            Console.Write(mas[i, j] + " ");
        }
        else
        {
            Console.Write(mas[i, j] + " ");
        }
    }
    Console.WriteLine();
}
