int n = int.Parse(Console.ReadLine());
bool isFirstArrSelected = true;
string[] firstArr = new string[n];
string[] secondArr = new string[n];

for (int i = 0; i < n; i++)
{
    string[] numbersArray = Console.ReadLine().Split();

    if (isFirstArrSelected)
    {
        firstArr[i] = numbersArray[0];
        secondArr[i] = numbersArray[1];
    }
    else
    {
        firstArr[i] = numbersArray[1];
        secondArr[i] = numbersArray[0];
    }

    isFirstArrSelected = !isFirstArrSelected;
}

Console.WriteLine(string.Join(" ", firstArr));
Console.WriteLine(string.Join(" ", secondArr));