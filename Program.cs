using System;

namespace session1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string b="       ";
            string c="";
            string d="";
            for (int i=1;i<6;i++)
            {
                c+=$"{i}";
                Console.WriteLine(b.Substring(i)+c+d);
                d=$"{i}{d}";
            }
          
        }
    }
    
}
