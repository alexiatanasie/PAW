using System;
namespace NameSpaceProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Ex1
            string s1 = "abc";
            string s2 = s1;
            string s33 = s1.Replace("abc", "ba");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s33);
            //Console.ReadLine(); // if I uncomment this, it will appear only s1,s2,s33, not ex 2

            //Ex2
            String s3 = "abc";
            String s4 = s3;
            s3 += "d";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.ReadLine(); 

            /*Strings are immutable--the contents of a string object cannot be changed after the object is created, although the syntax makes it appear as if you can do this. */
        // a brand new string is created each time we modify the initial string
        }
    }
}