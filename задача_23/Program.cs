string NumCub()
{
Console.WriteLine("Введите целое положительное число больше 0 ");
int N = int.Parse(Console.ReadLine());
int i = 1;
string result = "";

while (i <= N)
{
    result = result + i*i*i + ", ";
    i++;
}
return result;
}
Console.WriteLine(NumCub());
