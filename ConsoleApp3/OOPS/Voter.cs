using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.OOPS
{
    internal class Voter
    {
        long addhar;
        string votername;
        string votecasted;

        public void setaddhar(long card)
        {
            addhar = card;
        }
        public long getaddhar()
        {
            return addhar;
        }

        public void setvotername(string name)
        {
            votername = name;
        }
        public string getvotername()
        {
            return votername;
        }

        public void setvotecasted(string casted)
        {
            votecasted = casted;
        }
        public string getvotecasted()
        {
            return votecasted;
        }
    }
    class votertest
    {
        static void Main(string[] args)
        {
            Voter V1 = new Voter();
            V1.setaddhar(45566678888);
            V1.setvotername("ommm");
            V1.setvotecasted("BJP");



        }
    }
}
