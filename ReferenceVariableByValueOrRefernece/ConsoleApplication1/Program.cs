using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //a user defined datatype
    class Student
    {
        public String name { get; set; }
        public String cgpa { get; set; }
    }
    class Program
    {
        //The body of the function
        static void StringRefernecePassedByValue(String valStr,ref String refStr)
        {
            //Both of the passed reference variable are pointing to the same location
            Console.WriteLine("Are equal?: " + ReferenceEquals(valStr, refStr));
            
            //let's change the strings
            valStr = "Hello1";//a new string is created and now the valStr refer to it
            refStr = "Hello2";//a new string is created and now the refStr refer to it

            //let's confirm the output
            Console.WriteLine("Passed by Value: " + valStr);
            Console.WriteLine("Passed by Reference: " + refStr);

            //now both are changed are are no more refering to the same location
            Console.WriteLine("Are equal?: " + ReferenceEquals(valStr, refStr));
        }


        //the body of fucntion
        static void ClassRefernecePassedByValue(Student valStd, ref Student refStd)
        {
            //Both of the passed reference variable are pointing to the same location
            Console.WriteLine("Are equal?: " + ReferenceEquals(valStd, refStd));

            //let's change the objects
            valStd.name = "Joseph";//changing the object refered by valStd
            refStd.name = "Mick";//changing the object refered by refStd 

            Console.WriteLine("Passed by Value: " + valStd.name);
            Console.WriteLine("Passed by Reference: " + refStd.name);

            //now both are same
            Console.WriteLine("Are equal?: " + ReferenceEquals(valStd, refStd));
        }


        static void Main(string[] args)
        {
            //let's create a string and pass it to a function as value and reference type
            String str = "Hello World";
            StringRefernecePassedByValue(str, ref str);

            //the reference that was passed by value is the one that is the actual reference
            //other one was a new refernece variable that has a copy of the reference
            Console.WriteLine("Actual String: " + str);


            //let's observe in case of Custom type
            Student student = new Student();
            student.name = "Ali";
            student.cgpa = "3.5";

            ClassRefernecePassedByValue(student, ref student);

            Console.WriteLine("Actual String: " + student.name);

            Console.ReadKey();
        }


        
    }
}
