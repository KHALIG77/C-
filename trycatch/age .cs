int age;
string wordage;


Console.WriteLine("Zehmet olmasa yasinizi daxil edin");
age=int.Parse(Console.ReadLine());
Console.WriteLine(age);
if (age>=18)
{
    Console.WriteLine("sürücülük vəsiqəsi ala bilərsiniz");
}
else
{
    age=18-age;
    wordage=age.ToString();

    Console.WriteLine("Suruculuk vesiqesi almaq ucun " + wordage +  " il gozlemelisiniz");
}


