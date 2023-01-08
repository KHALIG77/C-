using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleFinal.Interfaces;
using ConsoleFinal.Statics;

namespace ConsoleFinal
{
    internal class GroupService : IGroupService
    {
        public void CreateGroup(string categoryName, int groupNo, bool isOnline)
        {
            if (categoryName != null && groupNo != 0)
            {
                bool hasGroup = false;
                
                foreach (var group in ApplicationGroups.Groups)
                {
                    if (categoryName == group.No.Substring(0,1) && groupNo.ToString() == group.No.Substring(1))
                    {
                        hasGroup = true;
                        break;
                    }
                }


                if (!hasGroup)
                {
                    Qrup qrup = new Qrup();

                    qrup.No = categoryName + groupNo;
                    qrup.IsOnline = isOnline;
                    if (isOnline)
                    {
                        qrup.Limit = 15;
                    }
                    else
                    {
                        qrup.Limit = 10;
                    }
                    ApplicationGroups.Groups.Add(qrup);
                }
                else
                {
                    Console.WriteLine("Bele bir qrup var");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }

        public void CreateStudent(string name ,string groupName, bool? isGuarantee)
        {
            if (name != null && groupName != null && isGuarantee != null)
            {
                bool hasGroup = false;

                if (ApplicationGroups.Groups.Count != 0)
                {
                    foreach (var group in ApplicationGroups.Groups)
                    {
                        if (group.No.ToLower() == groupName.ToLower())
                        {
                            Student student = new Student();
                            
                            student.FullName = name;
                            student.GroupNo = group.No;
                            student.Type = (bool)isGuarantee;

                            ApplicationGroups.Students.Add(student);

                            group.Students.Add(student);
                            hasGroup = true;
                            break;
                        }
                    }

                    if (!hasGroup)
                    {
                        Console.WriteLine($"{groupName} adinda qrup yoxdur , ilk once qrupu yaradin");
                        Console.WriteLine("-----------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Ilk Once Qrup Yaradin");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }

        public void EditGroup(string groupName)
        {
            if (groupName != null)
            {
                bool hasGroup = false;

                foreach (var group in ApplicationGroups.Groups)
                {
                    if (group.No.ToLower() == groupName.ToLower())
                    {
                        hasGroup = true;
                        Console.WriteLine("Qrupun Yeni Nomresini Daxil Edin");

                        int newGroupNo;

                        CheckIsNumberGroupNo:

                        bool isNumber = int.TryParse(Console.ReadLine(), out newGroupNo);

                        if (!isNumber)
                        {
                            Console.WriteLine("Reqem Daxil edin");
                            goto CheckIsNumberGroupNo;
                        }

                        if ((group.No.Substring(0, 1) + newGroupNo.ToString()).ToLower() == group.No)
                        {
                            Console.WriteLine("Bele qrup var onsuzda");
                        }
                        else
                        {
                            group.No = group.No.Substring(0, 1) + newGroupNo.ToString();
                        }
                        break;
                    }
                }

                if (!hasGroup)
                {
                    Console.WriteLine("Bele bir qrup yoxdur");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }

        public void ShowAllStudents(string groupName)
        {
            if(groupName != null)
            {
                bool hasGroup = false;

                foreach (var student in ApplicationGroups.Students)
                {
                    if (student.GroupNo.ToLower() == groupName.ToLower())
                    {
                        int studentsCount = 0;
                        foreach (var group in ApplicationGroups.Groups)
                        {
                            if(group.No.ToLower() == groupName.ToLower())
                            {
                                studentsCount = group.Students.Count;
                            }
                        }
                        Console.WriteLine($"{student.GroupNo} qrupunda {studentsCount} telebe var");
                        Console.WriteLine("-----------------------------------------");
                        hasGroup = true;
                        break;
                    }             
                }

                if(!hasGroup)
                {
                    Console.WriteLine("Bele bir qrup yoxdur");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }

        public void ShowGroups()
        {
            bool hasGroup = false;

            if (ApplicationGroups.Groups.Count != 0)
            {
                foreach (var group in ApplicationGroups.Groups)
                {
                    string groupType = "";
                    if(group.IsOnline)
                    {
                        groupType = "Online";
                    }
                    else
                    {
                        groupType = "Offline";

                    }
                    Console.WriteLine($"Qrupun Nomresi : {group.No} , Qrupun Tipi : {groupType} , Qrupun Telebelerinin Sayi : {group.Students.Count}");
                    Console.WriteLine("-----------------------------------------");

                }
                hasGroup = true;
            }

            if (!hasGroup)
            {
                Console.WriteLine("Bele bir qrup yoxdur");
                Console.WriteLine("-----------------------------------------");
            }
        }

        public void ShowStudentsInGroup(string groupName)
        {
            if(groupName != null)
            {
                bool hasGroup = false;

                if (ApplicationGroups.Groups.Count != 0)
                {
                    foreach (var group in ApplicationGroups.Groups)
                    {
                        if(group.No == groupName)
                        {
                            foreach (var student in group.Students)
                            {
                                string studentStatus = "";
                                if (student.Type)
                                {
                                    studentStatus = "Zemanetli";
                                }
                                else
                                {
                                    studentStatus = "Zemanetsiz";

                                }
                                Console.WriteLine($"Telebenin Adi ve soyadi : {student.FullName} , Telebenin Statusu: {studentStatus}");
                                Console.WriteLine("-----------------------------------------");
                            }
                            hasGroup = true;
                        }
                    }
                }

                if (!hasGroup)
                {
                    Console.WriteLine("Bele bir qrup yoxdur");
                }
            }
        }
    }
}
