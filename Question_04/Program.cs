// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

System.Console.Write("Enter amount of lines: ");
int lines = int.Parse(Console.ReadLine()!);
int[,] tringle = new int[lines, lines];

// int lineUp = 0;
int element = 1;

// for (int i = 0; i < lines; i++)
// {
//     element = 1;
//     lineUp++;
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write($"{element} ");
//         element = element + lineUp;
//     }
//     Console.WriteLine();
// }

void FillTringle(int[,] tringle)
{
    for (int i = 0; i < lines; i++)
    {
        tringle[i, 0] = 1;
        tringle[i, i] = 1;
    }
    for (int i = 2; i < lines; i++)
    {
        for (int j = 1; j < i; j++)
        {
            tringle[i, j] = tringle[i - 1, j] + tringle[i - 1, j - 1];
        }
    }
}
void PrintTringle(int[,] tringle)
{
    int space = lines;
    for (int i = 0; i < lines; i++)
    {
        for (int k = 0; k < space; k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j < lines; j++)
        {
            
            if (tringle[i, j] != 0)
            {
                Console.Write($"{tringle[i, j]} ");
            }
        }
        space--;
        Console.WriteLine();
    }
}
FillTringle(tringle);
PrintTringle(tringle);


