string[] input_1 = Console.ReadLine().Split(' ');
string[] input_2 = Console.ReadLine().Split(' ');
char[] char_array_1, char_array_2;

if (input_1.Length <= input_2.Length) {
    char_array_1 = Array.ConvertAll(input_1, char.Parse);
    char_array_2 = Array.ConvertAll(input_2, char.Parse);
}else{
    char_array_1 = Array.ConvertAll(input_2, char.Parse);
    char_array_2 = Array.ConvertAll(input_1, char.Parse);
}
int i = 0;
while(i < char_array_1.Length)
{
    if (char_array_1[i] > char_array_2[i])
    {
        print(char_array_2);
        print(char_array_1);
        break;
    }
    else if (char_array_1[i] == char_array_2[i] && i + 1 < char_array_1.Length)
    {
        i++;
    }
    else {
        print(char_array_1);
        print(char_array_2);
        break;
    }
}

static void print(char[] char_array){
    for(int i = 0; i < char_array.Length; i++)
    {
        Console.Write(char_array[i]);
    }
    Console.WriteLine();
}
