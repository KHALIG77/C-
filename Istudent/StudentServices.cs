using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class StudentServices : IStudentServices
    {
        public bool Create(string Name, string Surname,int Average)
        {

            bool isSuccesed = false;
            Student newStudent = new Student();
            newStudent.Name = Name;
            newStudent.Surname = Surname;
            newStudent.Average = Average;   

            if (newStudent.Name != null && newStudent.Surname != null&&newStudent.Average>=0&&newStudent.Average<=100 )
            {
                Group.Students[Student.Id - 1] = newStudent;
                isSuccesed = true;
            }

            return isSuccesed;
            //Group.Students[Student.Id] = newStudent;


            //int[] array = new int[2];

            //Group.Students[] = { newStudent };
            //Array.Resize(ref Group.Students[100], array.Length + 1);

        }

        public void Delete(int Id)
        {
            if (Group.Students[Id - 1] != null)
            {
                Group.Students[Id - 1] = null;
            }
            else
            {
                Console.WriteLine("Bu Id li student yoxdur");
            }
        }

        public void Edit(int Id, string Name, string Surname)
        {

            if (Group.Students[Id - 1] != null)
            {
                if (Name.Length < 15 && Name.Length > 3 && !String.IsNullOrEmpty(Name))
                {
                    Group.Students[Id - 1].Name = Name;
                }
                else
                {
                    Console.WriteLine("Name 3 herfden boyuk , 15 herfden balaca ve bos olmasin");
                }


                if (Surname.Length < 15 && Surname.Length > 3 && !String.IsNullOrEmpty(Surname))
                {
                    Group.Students[Id - 1].Surname = Surname;
                }
                else
                {
                    Console.WriteLine("Surname 3 herfden boyuk , 15 herfden balaca ve bos olmasin");
                }
            }
            else
            {
                Console.WriteLine("Bele Id li telebe yoxdur");
            }
        }

        public void GetAll()
        {
            

            for (int i = 0; i < Group.Students.Length; i++)
            {
                if (Group.Students[i] != null)
                {
                    Console.WriteLine($"Ad : {Group.Students[i].Name} , Soyad : {Group.Students[i].Surname}");
                }
                else
                {
                    break;
                }
            }
        }

        public void GetByID(int Id)
        {
            if (Group.Students[Id - 1] != null)
            {
                Console.WriteLine($"Ad : {Group.Students[Id - 1].Name} , Soyad : {Group.Students[Id - 1].Surname}");
            }
            else
            {
                Console.WriteLine("Bu Id li student yoxdur");
            }
        }
    }
}
