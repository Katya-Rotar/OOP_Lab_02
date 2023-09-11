int[] array_input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int start = 0, len = 1;
int bestStart = 0, bestLen = 0;
for (int i = 1; i < array_input.Length; i++) {
    if (array_input[i] == array_input[start])
    {
        len++;
    }
    else {
        if(len > bestLen)
        {
            bestLen = len;
            bestStart = start;
        }
        start = i;
        len = 1;
    }
    if (start + len == array_input.Length && len > bestLen)
    {
        bestLen = len;
        bestStart = start;
    }
}
for (int i = bestStart; i < bestStart + bestLen; i++) {
    Console.Write(array_input[i] + " ");
}