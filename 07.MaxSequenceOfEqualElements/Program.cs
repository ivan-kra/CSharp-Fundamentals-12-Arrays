﻿string[] symbols = Console.ReadLine().Split();
int bestCount = 0;
string bestCountSymbol = "";

for (int i = symbols.Length - 1; i >= 0; i--)
{
    int count = 1;
    for (int j = i - 1; j >= 0; j--)
    {
        if (symbols[i] == symbols[j])
        {
            count++;
            if (bestCount <= count)
            {
                bestCount = count;
                bestCountSymbol = symbols[i];
            }
        }
        else
        {
            break;
        }
    }
}

for (int i = 0; i < bestCount; i++)
{
    Console.Write($"{bestCountSymbol} ");
}