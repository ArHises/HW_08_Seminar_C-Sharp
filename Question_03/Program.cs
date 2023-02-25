// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] CreateIntTreaD()
{
    Console.Write("Lines: ");
    int line = int.Parse(Console.ReadLine()!);

    Console.Write("Colons: ");
    int colon = int.Parse(Console.ReadLine()!);

    Console.Write("Deep: ");
    int deep = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,,] treaD = new int[line, colon, deep];
    return treaD;
}
int[,,] FillTreaD(int[,,] treaD)
{
    int input = 10;
    for (int i = 0; i < treaD.GetLength(0); i++)
    {
        for (int j = 0; j < treaD.GetLength(1); j++)
        {
            for (int k = 0; k < treaD.GetLength(2); k++)
            {
                treaD[i, j, k] = input;
                input++;
            }
        }
    }
    return treaD;
}
void PrintTreaD(int[,,] treaD)
{
    for (int i = 0; i < treaD.GetLength(0); i++)
    {
        for (int j = 0; j < treaD.GetLength(1); j++)
        {
            for (int k = 0; k < treaD.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] = {treaD[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] treaD = CreateIntTreaD();
FillTreaD(treaD);
PrintTreaD(treaD);