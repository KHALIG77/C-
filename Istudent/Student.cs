using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public Student()
        {
            Id += 1;
        }

        public static int Id;

        private string name; 
        public  string Name
        {
            get { return name; }
            set 
            {
                if (value.Length < 15 && value.Length > 3 && !String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name 3 herfden boyuk , 15 herfden balaca ve bos olmasin");
                }
            }
        }

        private string surname; 

        public string Surname
        {
            get { return surname; }
            set 
            {
                if (value.Length < 15 && value.Length > 3 && !String.IsNullOrEmpty(value))
                {
                    surname = value;
                }
                else
                {
                    Console.WriteLine("Surname 3 herfden boyuk , 15 herfden balaca ve bos olmasin");
                }
            }
        }

        private int average;

        public int Average
        {
            get { return average; }
            set 
            { 

                if(value >= 0 && value <= 100)
                {
                    average = value;
                }
                else
                {
                    Console.WriteLine("Average 0 dan boyuk , 100 den kicik eded daxil edin");
                }
            }
        }
    }
}
