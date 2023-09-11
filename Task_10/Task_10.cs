int[] array_input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int n = int.Parse(Console.ReadLine());
int output = 0;
for (int i = 0; i < array_input.Length; i++) {
    for (int j = i + 1; j < array_input.Length; j++) {
        if (Math.Abs(array_input[i] - array_input[j]) == n) { 
        output++;
        }
    }
}
Console.WriteLine(output);
