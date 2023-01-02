using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp7.Iservice;

namespace ConsoleApp7
{
     public class Service : IService
    {

        Hotel hotel = new Hotel();

        public void Create(int no,int price)
        {
           
            Room room1 = new Room();
            room1.No= no;
            room1.Price= price;
            room1.Isrezerved = false;
            Array.Resize(ref hotel.rooms,hotel.rooms.Length+1);
            hotel.rooms[hotel.rooms.Length-1]=room1;
         
            

        }
        public void RoomInfo() {
            if (hotel.rooms.Length < 1)
            {
                Console.WriteLine("Hec  bir Melumat yoxdur");
            }
            else
            {
                for (int i = 0; i < hotel.rooms.Length; i++)
                {
                    Console.WriteLine($"Room NO ={hotel.rooms[i].No}, Room PRICE={hotel.rooms[i].Price},Rezerv STATUS={hotel.rooms[i].Isrezerved}");



                }
            }
        }
        public void IdSearchRezerv(int id)
        {
            {
                if(hotel.rooms.Length == 0)
                {
                       Console.WriteLine("Bu idde otaq yoxdur");
                }
                else { 


                    for (int i = 0; i < hotel.rooms.Length; i++)
                    if (id == hotel.rooms[i].Id)
                    {
                        if (hotel.rooms[i].Isrezerved == true) {
                            Console.WriteLine("Bu otaq artiq rezerv olunub");
                        
                        }
                        else {
                            hotel.rooms[id - 1].Isrezerved = true;
                            
                        }
                      

                    }
                        else
                        {
                            Console.WriteLine("Bu idde otaq yoxdur");
                        }
                

                }
                
                   
                {

                }

            }

       

        }
       

        

       
    }
}
