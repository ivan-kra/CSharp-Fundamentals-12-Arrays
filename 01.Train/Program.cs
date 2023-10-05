using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
int sum = 0;

for (int i = 0; i < numbers.Length; i++) 
{
    numbers[i] = int.Parse(Console.ReadLine());
    sum += numbers[i];
}

Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(sum.ToString());