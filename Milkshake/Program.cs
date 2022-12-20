
  Product product = new Product();
  product.Sell();

  Milk milk = new Milk(Volume(), Fatrate());

static int Volume()
{
    int  volumme = 0;
    bool status = false;
    while (!status)
    {
        Console.WriteLine("Zehmet olmasa volume daxil edin");
      
     status = int.TryParse(Console.ReadLine(), out volumme);

    }
    
    return volumme;
}
    

static int Fatrate()
{
    int fatrate = 0;
    bool status2 = false;
    while (!status2)
    {
        Console.WriteLine("Zehmet olmasa fatrate daxil edin");
       status2= int.TryParse(Console.ReadLine(), out fatrate);
    }
    
    return fatrate;   
}