//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");

int num = Convert.ToInt32(Console.ReadLine());
//12345
int a = num/10000; num=num-a*10000;
int b = num/1000; num=num-b*1000;
int c = num/100; num=num-c*100;
int d = num/10; num=num-d*10;
int f = num%10;

if (a==f && b==d)
     Console.WriteLine("число является палиндромом");
else 
     Console.WriteLine("число не является палиндромом");

