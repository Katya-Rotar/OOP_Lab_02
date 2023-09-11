int[] array_input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int start = 0, len = 0, bestStart = 0, bestLen = 0;
for (int i = 0; i < array_input.Length; i++) {
    start = i;
    len = 1;
    for (int j = i + 1; j < array_input.Length; j++) {
        if (array_input[start] == array_input[j])
        {
            len++;
        }
    }
    if(len > bestLen)
    {
        bestLen = len;
        bestStart = start;
    }
}
Console.WriteLine(array_input[bestStart]);