
public class Product : Productcheck
{

    int totalincome;

    public void Sell()
    {
        if (count>0)
        {

            totalincome+=price;
            count=count-1;


        }
        else
        {
            Console.WriteLine("Depoda mehsul bitib");
        }
    }



}
public class Milk : Productcheck
        {
            int _volume;
            int _fatrate;

            public Milk(int volume,int fatrate):base(volume,fatrate )
            {

                _volume=volume;
                _fatrate=fatrate;
              

            }
    public int Volume { get; set; }
    public int Fatrate    { get; set; }


}

    

