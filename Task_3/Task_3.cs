int[] array_input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int half_array = array_input.Length / 2; //2
int fourth_part_array = half_array / 2; //1

int[] array_sum = new int[half_array];
for (int x = 0, i = 0, j = half_array -1; x < fourth_part_array && i < fourth_part_array && 
    j >= fourth_part_array; x++, i++, j--) {
    array_sum[x] = array_input[i] + array_input[j];
    array_sum[x + fourth_part_array] = array_input[i + half_array] + array_input[j + half_array];
}
for (int i = 0; i < array_sum.Length; i++) {
    Console.Write(array_sum[i] + " ");
}