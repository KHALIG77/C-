using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IStudentServices
    {
        bool Create(string Name, string Surname,int Average);
        void Delete(int Id);

        void Edit(int Id, string Name, string Surname);
        void GetAll();

        void GetByID(int Id);   
    }
}
