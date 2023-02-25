// Найти произведение двух матриц

int[,] CreateIntTable()
{
    Console.Write("Lines: ");
    int line = int.Parse(Console.ReadLine()!);

    Console.Write("Colons: ");
    int colon = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,] table = new int[line, colon];
    return table;
}
int[,] FillTable(int[,] table)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(0, 10);
        }
    }
    return table;
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i, j]);
        }
        Console.WriteLine();
    }
}
bool EqualMatrixes(int[,] first, int[,] second) => first.GetLength(0) == second.GetLength(0) && first.GetLength(1) == second.GetLength(1);
void MultiplyTwoMatrixes(int[,] first, int[,] second)
{
    if (EqualMatrixes(first,second))
    {
        for (int i = 0; i < first.GetLength(0); i++)
        {
            for (int j = 0; j < first.GetLength(1); j++)
            {
                Console.Write($"{first[i,j] *second[i,j]} ");
            }
            Console.WriteLine();
        }

    }
}
int[,] first = CreateIntTable();
int[,] second = CreateIntTable();

FillTable(first);
FillTable(second);

PrintTable(first);
Console.WriteLine();
PrintTable(second);

MultiplyTwoMatrixes(first,second);