using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Methods
    {
       


        public static int MenuInput()
        {


            bool status = true;
            while (status)
            {
                status = int.TryParse(Console.ReadLine(), out int result);
                //Console.Clear();
                if (result > 0 && result < 5 && status == true)
                {
                    status = false;
                    return result;

                }
                else
                {
                    Console.WriteLine("1-4 intercalinda eded girin");
                    status = true;
                }



            }
            return 0;


        }
        public static int IntCheck(string info)
        {
            Console.WriteLine($"{info}");
            bool statusint = true;

            while (statusint)
            {
                
                statusint = int.TryParse(Console.ReadLine(), out int intresult);

                if (statusint == true)
                {
                    return intresult;


                }
                else
                {
                    statusint = true;
                    Console.WriteLine("Zehmet olmasa reqem daxil edin");
                }



            }
            return 0;

        }
        public  string  RoomNo()
        {
          string roominfo=  "Zehmet olmasa otaq No-su daxil edin ";
            return roominfo;    
          
            
        }
        public string RoomPrice()
        {
            string priceinfo = "Zehmet olmasa qiymet daxil edin";
            return  priceinfo; 
        }
        public string IdSearch()
        {
            string Idinfo = "Zehmet olmasa ID daxil edin";
            return Idinfo;
        }
        
        }


















    }




    





