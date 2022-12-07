using System;
int number;
do
{

    Console.WriteLine("Zehmet olmasa  musbet eded daxil edin");
    number=int.Parse(Console.ReadLine());
} while (number<0);

if (number<=100) {
    if (number>=91&&number<=100)
    {

        Console.WriteLine("A");
    }
   else if (number>=81&&number<=90)
    {

        Console.WriteLine("B");
    }
    else if (number>=71&&number<=80)
    {

        Console.WriteLine("C");

    }
    else if (number>=61&&number<=70)
    {

        Console.WriteLine("D");
    }
    else if (number>=51&&number<=60)
    {

        Console.WriteLine("E");
    }
    else {

        Console.WriteLine("Kesildiniz");
    }
    


}
else
{
    Console.WriteLine("Zehmet olmasa 0-100 intervalinda eded daxil edin");
}


