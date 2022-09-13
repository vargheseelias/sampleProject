using System;
using System.Linq;

namespace sampleProject
{
    class Program
    {
        static void Main(string[] name)
        {
            InvokeCheck();
            string value;
            Console.Write("Do u wish to continue ?(Y/N) ");
            value = Console.ReadLine();
            if (value.Equals("Y"))
            {
                InvokeCheck();
            }
        }
        public static void InvokeCheck()
        {
            string val;
            Console.Write("Enter Name To Search: ");
            val = Console.ReadLine();
            Check(val);
            
        }

        public static void Check(string name)
        {
           
            string[] names = { "Varghese", "Jikku", "Midhun", "Liju", "Sree", "Antoney", "Zeara", "Sherin", "Tony" };
            if(names.Contains(name))
            {
                Console.WriteLine("Found Name =>{0}", name);
            }
            else
            {
                Console.WriteLine("Name Not Found");

            }

         


        }
    }
}
