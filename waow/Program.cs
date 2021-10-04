using System;
using System.IO;
using Figgle;

namespace waow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dumbass shit xd");
        
            
            string Font = Console.ReadLine();
            
            if (Font.Equals("1"));
            {
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.Ogre.Render(Text));
            }

            
            
            
            
            


        }
    }
}