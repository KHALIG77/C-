using ConsoleFinal.Statics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleFinal
{
    internal static class MenuMethods
    {
        private static GroupService groupservice = new GroupService();
        public static void MenuCreateGroup()
        {
            Console.Clear();
            Console.WriteLine("Choose category");
            Console.WriteLine("   ");




            foreach (GroupCategory category in Enum.GetValues(typeof(GroupCategory)))
            {
                Console.WriteLine($" For {category} press {(int)category}");
                Console.WriteLine("-----------------------------------------");
            }


            int categoryNo;

            CheckIsNumberCategoryNo:

            bool isNumberCategoryNo = int.TryParse(Console.ReadLine(), out categoryNo);

            if (!isNumberCategoryNo)
            {
                Console.WriteLine("Reqem Daxil edin");
                goto CheckIsNumberCategoryNo;

            }

            string NewCategoryName = "";

            foreach (GroupCategory category in Enum.GetValues(typeof(GroupCategory)))
            {
                if (categoryNo == (int)category)
                {
                    NewCategoryName = category.ToString().Substring(0, 1);
                }
            }

            Console.WriteLine("Qrupun Nomresini secin");

            int groupNo;

            CheckIsNumberGroupNo:

            bool isNumber = int.TryParse(Console.ReadLine(), out groupNo);

            if (!isNumber)
            {
                Console.WriteLine("Reqem Daxil edin");
                goto CheckIsNumberGroupNo;
            }

            Console.WriteLine($"Qrup onlinedirmi?");
            Console.WriteLine($"Online Ucun 1 Secin");
            Console.WriteLine($"Online deyilse 0 Secin");

            bool IsOnline;
            int IntCreateGroup;

            CheckIsNumberIsOnline:

            bool CreateCheckStatus = int.TryParse(Console.ReadLine(), out IntCreateGroup);

            if (CreateCheckStatus)
            {
                if (IntCreateGroup == 0)
                {
                    IsOnline = false;
                }
                else if (IntCreateGroup == 1)
                {
                    IsOnline = true;
                }
                else
                {
                    Console.WriteLine("Duzgun Reqem Secin");
                    goto CheckIsNumberIsOnline;

                }
            }
            else
            {
                Console.WriteLine("Reqem Daxil Edin");
                goto CheckIsNumberIsOnline;
            }

            groupservice.CreateGroup(NewCategoryName, groupNo, IsOnline);
        }

        public static void MenuCreateStudent()
        {

            Console.WriteLine("Telebe Adi Daxil Edin");

            string fullName = Console.ReadLine();

            Console.WriteLine("Qrupun Nomresini Daxil Edin");

            string groupName = Console.ReadLine();


            Console.WriteLine($"Telebe Zemanetlidirmi?");
            Console.WriteLine($"Zemanetli ucun 1 Secin");
            Console.WriteLine($"Zemanetsiz ucun 0 Secin");

            bool isGuarantee;

            int IntCreateStudent;

        CheckIsNumberIsGuarantee:

            bool CreateStudentStatus = int.TryParse(Console.ReadLine(), out IntCreateStudent);

            if (CreateStudentStatus)
            {
                if (IntCreateStudent == 0)
                {
                    isGuarantee = false;
                }
                else if (IntCreateStudent == 1)
                {
                    isGuarantee = true;
                }
                else
                {
                    Console.WriteLine("Duzgun Reqem Secin");
                    Console.WriteLine("-----------------------------------------");
                    goto CheckIsNumberIsGuarantee;

                }
            }
            else
            {
                Console.WriteLine("Reqem Daxil Edin");
                goto CheckIsNumberIsGuarantee;
            }

            groupservice.CreateStudent(fullName, groupName, isGuarantee);

        }

        public static void MenuShowAllStudents()
        {
            Console.WriteLine("Qrupun Adini Daxil Edin");

            string groupName = Console.ReadLine();

            groupservice.ShowAllStudents(groupName);

        }

        public static void MenuShowAllGroups()
        {
            groupservice.ShowGroups();
        }

        public static void MenuShowStudentsInGroup()
        {
            Console.WriteLine("Qrupun Adini Daxil Edin");

            string groupName = Console.ReadLine();

            groupservice.ShowStudentsInGroup(groupName);

        }

        public static void MenuShowEditGroup()
        {
            Console.WriteLine("Qrupun Adini Daxil Edin");

            string groupName = Console.ReadLine();

            groupservice.EditGroup(groupName);

        }
       public static void Info()
        {
            Console.WriteLine("Choose one of them ");
            Console.WriteLine("   ");

            Console.WriteLine("1.Create new group");
            Console.WriteLine("---------------------------");


            Console.WriteLine("2.Show list of all groups");
            Console.WriteLine("-----------------------------");


            Console.WriteLine("3.Edit group");
            Console.WriteLine("-----------------------------");


            Console.WriteLine("4.Display a list of students in the group");
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("5.Show list of all students");
            Console.WriteLine("-----------------------------");


            Console.WriteLine("6.Create new student");
            Console.WriteLine("-----------------------------");

        }
        public static int MenuInput()
        {


            bool status = true;
            while (status)
            {
                status = int.TryParse(Console.ReadLine(), out int result);
            
                if (result > 0 && result < 7 && status == true)
                {
                    status = false;
                    return result;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter correctly");
                    break;
                    //status = true;
                }



            }
            return 0;


        }
        //public static int InputIntCheck()
        //{


        //}





    }
}
