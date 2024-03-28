int[] numsArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());

for (int i = 0; i < rotations; i++)
{

    int lastNum = numsArr[numsArr.Length - 1];

    for (int j = numsArr.Length - 1; j > 0; j--)
    {
        numsArr[j] = numsArr[j - 1];
    }

    numsArr[0] = lastNum;

}
Console.WriteLine(String.Join(", ", numsArr));

