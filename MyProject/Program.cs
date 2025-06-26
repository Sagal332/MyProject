using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentvariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name, mname, Dob, Pob, email, sex, ph0ne, status, faculty;

            String myname = "Sagal Abdulkadir Abdullahi";
            String mothersname = "Fartuun Abdullahi Farah";
            String dateboth = "2005";

            String placeboth = "in galkacyo";
            String Emaile = "Sagalabdulkadir85@gmail.com";
            int phonenumber = 3333333;
            String gender = "female";
            String statuss = "single";
            String facult = "computer science";
            Console.WriteLine("magacaygu waa " + myname);
            Console.WriteLine("magaca hooyadayna waa " + mothersname);
            Console.WriteLine("waxan dhashay " + dateboth);
            Console.WriteLine("waxan ku dhashay " + placeboth);
            Console.WriteLine("emailkaygu waa" + Emaile);
            Console.WriteLine("numberkaygu waa" + phonenumber);
            Console.WriteLine("waxan ahay" + gender);
            Console.WriteLine("waxan ahay " + statuss);
            Console.WriteLine("waxan ahay " + facult);
            Convert.ToInt32(dateboth);
            Console.WriteLine(dateboth);
        }
    }
}