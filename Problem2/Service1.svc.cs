using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace Problem2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string sort(string s)
        {
            //array1 will store each value
            int[] array1 = new int[20];

            //variables for length, number amount and more information needed to sort string
            int n = 0;
            int q = s.Length;
            string temp = "";
            int a;

            //for loop stores characters into a string until it reaches a coma. it then stores number
            for (int i = 0; i < q; i++)
            {
                //chech for coma and store number into array
                if (s[i] == ',' )
                {

                    int.TryParse(temp, out a);
                    array1[n] = a;
                    n++;
                    temp = "";
                }
                //if current char is not a coma, add char to string
                else
                {
                    temp = temp + s[i];
                }
            }
            //add last number to array1
            int.TryParse(temp, out a);
            array1[n] = a;

            
            //for loop and while loop sort the array of numbers with insertion sort
            int j, t;
            for (int i = 0; i < n+1; i++)
            {
                t = array1[i];
                j = i - 1;

                //sort numbers in indexes to the left of i
                while(j >= 0 && array1[j] > t)
                {
                    array1[j + 1] = array1[j];
                    j = j - 1;
                }
                array1[j + 1] = t;
            }

            //store sorted numbers into a string seperated by comas
            string final = "";
            for (int i = 0; i < n+1; i++)
            {
                final += array1[i].ToString();
                if (i != n)
                {
                    final += ",";
                }
            }
            return final;
        }
    }
}
