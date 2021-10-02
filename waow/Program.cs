using System;
using System.IO;

namespace waow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to waow (dumbassMP)");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("were music tell me please");

            string DirMusic = Console.ReadLine();

            Console.WriteLine("okok so ur music is in " + DirMusic);
            
            
            DirectoryInfo d = new DirectoryInfo(DirMusic);    
            FileInfo[] Files = d.GetFiles();  
            Console.WriteLine("So ur music is");  
            Console.WriteLine("---------------------------------------------------------------------------------------");  
            foreach (FileInfo file in Files)  
            {                  
                Console.WriteLine(file.Name);  
            }  
            Console.ReadKey();  
   


        }
    }
}