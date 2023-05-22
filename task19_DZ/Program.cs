// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int CheckNumOfChar(int some_num)
{
    int prove = some_num%10000;
    if (prove==0) {Console.WriteLine($"Введено число{some_num}");}
    else          {Console.WriteLine("-число не пятизначное");    } 
    return some_num;
}
int ReverseInt(int some_num)
{
    int reverseNum = 0;
    while(some_num!=0)
    {
        reverseNum=reverseNum*10+some_num%10;
        some_num/=10;
    }
    Console.WriteLine($"{reverseNum}");
    return reverseNum;
}
System.Console.Write("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Пользователем введено число {user_num}");
if (user_num == ReverseInt(CheckNumOfChar(user_num))) {System.Console.WriteLine($"Это число{user_num} -  палиндром");}
else                                                  {System.Console.WriteLine($"Это число{user_num} - не полиндром");}

// System.Console.WriteLine($"Это число{user_num} -  палиндром");
// System.Console.WriteLine($"Это число{user_num} - не полиндром");