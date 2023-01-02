using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
 public  class Room
    {
        public Room()
        {

            _id++;
            Id = _id;

        }

        private static int _id=0;
        public readonly int Id;

        int _no;

        int _price;

    public  bool _isrezerved;

        public int No
        {
            get
            {
                return _no;
            }
            set
            {
               _no= value;
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set {
            

                _price= value;  
            }
        }

        public  bool Isrezerved
        {
            get
            {

                return _isrezerved;
            }

            set
            {
                _isrezerved= value; 

            }
        }

      
    }
}
