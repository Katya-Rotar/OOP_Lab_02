using System.Text;
// Прочитати два масиви слів і знайдіть довжину найбільшого спільного початку або кінця 
string input_1 = Console.ReadLine();
string input_2 = Console.ReadLine();

string[] array_1, array_2;
if (input_1.Length < input_2.Length)
{
    array_1 = input_1.Split(' ');
    array_2 = input_2.Split(' ');
}
else {
    array_1 = input_2.Split(' ');
    array_2 = input_1.Split(' ');
}
int output = 0;
for (int i = 0; i < 2; i++)
{
    output = 0;
    for (int j = 0; j < array_1.Length; j++)
    {
        if (array_1[j].Equals(array_2[j])){
            output++;
        }
        else
        {
            Array.Reverse(array_1);
            Array.Reverse(array_2);
            break;
        }
    } 
}
Console.WriteLine(output);