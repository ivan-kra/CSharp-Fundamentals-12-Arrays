string[] array = Console.ReadLine().Split();
int n = int.Parse(Console.ReadLine());

string[] newArray = new string[array.Length];


for (int k = 0; k < array.Length; k++)    //или друг начин за копиране на масив: newArray = (string[])array.Clone();
{
    newArray[k] = array[k];
}


for (int i = 0; i < n; i++)
{

    for (int k = 0; k < array.Length; k++)
    {
        array[k] = newArray[k];
    }

    for (int j = 0; j < array.Length - 1; j++)
    {
        newArray[j] = array[j + 1];
        newArray[array.Length - 1] = array[0];
    }
}

Console.WriteLine(string.Join(" ", newArray));