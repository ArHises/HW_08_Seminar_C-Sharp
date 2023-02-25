// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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
            table[i, j] = rnd.Next(10, 100);
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
int[] GetIndexOfMinimal(int[,] table)
{
    int[] index = new int[] { 0, 0 };
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[index[0], index[1]] > table[i, j])
            {
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}
int[,] DeleteColonAndLineOfMinimal(int[,] table)
{
    int[] minIndex = GetIndexOfMinimal(table);
    Console.WriteLine($"index of minimal is L: {minIndex[0] + 1} C: {minIndex[1] + 1}");
    int[,] final = new int[table.GetLength(0) - 1, table.GetLength(1) - 1];

    for (int i = 0, ij = 0; i < table.GetLength(0); i++)
    {
        if(i != minIndex[0])
        {
            for (int j = 0, fj = 0; j < table.GetLength(1); j++)
            {
                if(j != minIndex[1])
                {
                    final[ij,fj] = table[i,j];
                    fj++;
                }
            }
            ij++;
        }
    }
    return final;
}
int[,] first = CreateIntTable();
FillTable(first);
PrintTable(first);

System.Console.WriteLine();
first = DeleteColonAndLineOfMinimal(first);
PrintTable(first);
// Console.WriteLine($"index of minimal is L: {GetIndexOfMinimal(first)[0]} R: {GetIndexOfMinimal(first)[1]}");