using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_282_Project_Milestone_2.Business_Logic_Layer
{
    internal class BusinessOpperations
    {

        public Boolean Validate(string pass1,string pass2)
        {

            if (pass1 == pass2 )
            {
                return true;
            } else
            {
                return false;
            }

            
        }

        public Boolean ValidateLogin(string acc, string pass, List<string> arr)
        {

            if (acc == arr[0] && pass == arr[1])
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
