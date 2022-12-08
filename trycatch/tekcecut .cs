using System;
using System.Reflection.Metadata.Ecma335;

int number;
try
{
    number=int.Parse(Console.ReadLine());
    //Console.WriteLine(number);
}
catch(Exception look)
{
    Console.WriteLine("Duzgun daxil edin");
    throw;
}

if (number!=0) {
    if (number%1==0)
    {
        if (number%2==0)
        {
            Console.WriteLine("Cutdur");
        }
        else
        {
            Console.WriteLine("Tekdir");
        }
    }
    else
    {
        Console.WriteLine("Tam eded daxil edin");
    }
}
else
{
    Console.WriteLine("0 ne tekdir ne de cut");
}



