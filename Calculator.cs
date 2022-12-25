
sealed class Calculator : Prop, Icalculator, Imetod
{
    int _number1;
    int _number2;
    int _result;

    public override int Number1
    {
        get { return _number1; }
        set { _number1 = value; }
    }

    public override int Number2
    {
        get { return _number2; }
        set { _number2 = value; }
    }

    public override int Result
    {
        get { return _result; }
        set { _result = value; }
    }



    public void ICalculate()
    {

        int check = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (check)
        {
            case 1:
                Toplama();
                break;
            case 2:
                Cixma();
                break;
            case 3:
                Vurma();
                break;
            case 4:
                Bolme();

                break;

        }


    }



    public void Inputnumber()
    {
        Console.WriteLine("Zehmet olmasa reqem daxil edin");
        Number1 = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Ikinci reqemi daxil edin");

        Number2 = int.Parse(Console.ReadLine());
        Console.Clear();
        Information();


    }
    public void Toplama()
    {
        Result = Number1 + Number2;
        Console.WriteLine($"Netice= {Result}");
    }

    public void Vurma()
    {
        Result = Number1 * Number2;
        Console.WriteLine($"Netice= {Result}");
    }
    public void Bolme()
    {
        Result = Number1 / Number2;
        Console.WriteLine($"Netice= {Result}");
    }

    public void Cixma()
    {
        Result = Number1 - Number2;
        Console.WriteLine($"Netice= {Result}");
    }


}