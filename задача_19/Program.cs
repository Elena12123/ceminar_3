

Console.WriteLine("число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;
int dig = 0;
while(num > 0)
{
    dig = num % 10;
    rev = rev * 10 + dig;
    num = num /10;
}
    
if(temp == rev)
{
    Console.WriteLine("Палидром");
}


Console.WriteLine("Не палидром");

