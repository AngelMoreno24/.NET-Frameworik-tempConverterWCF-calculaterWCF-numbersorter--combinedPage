using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Problem1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //converts celsius to fahrenheit
        public int c2f(int c)
        {
            int c2f = (c*9/5)+32;
            return c2f;
        }

        //converts fahrenheit to celsius 
        public int f2c(int f)
        {
            int f2c = (f-32)*5/9;
            return f2c;
        }
    }
}
