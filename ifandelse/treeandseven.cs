
using System;
int num;
do
{

    Console.WriteLine("Zehmet olmasa  musbet eded daxil edin");
    num=int.Parse(Console.ReadLine());
} while (num<0);
if (num%21==0)
{
    Console.WriteLine("Daxil olunan eded 3 ve 7 -ye bolunur");
}
else
{
    Console.WriteLine("Daxil olunan eded 3 ve 7 -ye bolunmur");
}


