using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPSHW
{
    internal class Teacher
    {
        int tid;
        string tname;
        long mobileno;

        public Teacher(int tid, string tname, long mobileno)
        {
            Tid = tid;
            Tname = tname;
        }
        
        public int Tid { get => Tid; set => Tid = value; }
        public string Tname { get => Tname; set => Tname = value; }
        public long Mobileno { get => mobileno; set => mobileno = value; }
    }


    

}
    
     





    


    



