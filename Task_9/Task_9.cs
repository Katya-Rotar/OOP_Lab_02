string input = Console.ReadLine();
char[] chars_array = input.ToCharArray();
char[] English_alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 
    'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
for (int i = 0; i < chars_array.Length; i++) { 
    for(int j = 0; j < English_alphabet.Length; j++){
        if (chars_array[i].Equals(English_alphabet[j]))
        {
            Console.WriteLine(chars_array[i] + " -> " + j);
            break;
        }
    }
}