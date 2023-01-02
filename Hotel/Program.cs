//using System.Diagnostics;

//class Room
//{
//    Id
//    No
//Price
//IsRezerved
//}
//Otel classimiz var 
//id
//name
//Rooms[] Room;
//propertileri var



//1.Click olunanda yeni otaq yaratsin ve otel classindaki room arrayine elave olunsun
//2.Click olunanda Butun otaqlar gorsensin
//3.Click olunanda id ye gore otaqi rezerv edin eger otaq rezerv olunubsa onceden artiq rezerv olunub deye error mesaji cixarsin eks teqdirde rezerv olunsun 
//4. Click olunanda Program dayansin

//Ncapsulation, Service mentiqinden istifade olunsun
using ConsoleApp7;
Methods methods= new Methods();
Service room=new Service();
do
{
    InfoRoom.Info();

    switch (Methods.MenuInput())

    {
       

        case 1:
            room.Create(Methods.IntCheck(methods.RoomNo()), Methods.IntCheck(methods.RoomPrice()));
            Console.Clear();


            break;
            
        
        
        case 2:
            Console.Clear();
            room.RoomInfo();
          

            break; 
        
        case 3:
            room.IdSearchRezerv(Methods.IntCheck(methods.IdSearch()));
            //Console.Clear();
            break;  

        case 4:
            Console.Clear();
            return;
           

        default:
            break;
    }








} while(true);










