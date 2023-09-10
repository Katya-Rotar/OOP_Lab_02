// Сума обертань масиву

string[] input = Console.ReadLine().Split(' ');
int[] array_input= Array.ConvertAll(input, int.Parse);

//int n = Convert.ToInt32(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[] sum = new int[array_input.Length];
for (int i = 0; i < n; i++)
{
    int[] rotated = new int[array_input.Length];
    rotated[0] = array_input[array_input.Length - 1];
    for (int j = 1; j < array_input.Length; j++) {
        rotated[j] = array_input[j - 1];
    }

    for (int j = 0; j < array_input.Length; j++) {
        sum[j] += rotated[j];
        array_input[j] = rotated[j];
        if (i == n - 1)
        {
            Console.Write(sum[j] + " ");
        }
    }

}