using System;
using System.IO;
using System.Threading;
using Figgle;

namespace waow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                FiggleFonts.Slant.Render("Hello"));
            Console.WriteLine("Do You Want To See Fonts Available?");
            Console.WriteLine("1 = Yes");
            Console.WriteLine("2 = No");
            string Preview = Console.ReadLine();
            
            if (Preview.Equals("1"))
            {
                Console.WriteLine( 
                    FiggleFonts.Graffiti.Render("1 Test"));
                
                Console.WriteLine( 
                    FiggleFonts.ThreePoint.Render("2 Test"));
                
                Console.WriteLine( 
                    FiggleFonts.Ogre.Render("3 Test"));
                
                Console.WriteLine( 
                    FiggleFonts.Rectangles.Render("4 Test"));
                
                Console.WriteLine( 
                    FiggleFonts.Slant.Render("5 Test"));
                
            }
            else if (Preview.Equals("2"))
            {
                
                
                
            }
                
                
            Console.WriteLine("Select the font (you can select from 1-5");

            string Font = Console.ReadLine();
            
            if (Font.Equals("1")) 
            {
                Console.WriteLine("Type the text that you want to make look fancy");
                
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.Graffiti.Render(Text));
            }
           else if (Font.Equals("2"))
            {
                Console.WriteLine("Type the text that you want to make look fancy");
                
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.ThreePoint.Render(Text));
            }
            else if (Font.Equals("3"))
            {
                Console.WriteLine("Type the text that you want to make look fancy");
                
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.Ogre.Render(Text));
            }
            else if (Font.Equals("4"))
            {
                Console.WriteLine("Type the text that you want to make look fancy");
                
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.Rectangles.Render(Text));
            }
            else if (Font.Equals("5"))
            {
                Console.WriteLine("Type the text that you want to make look fancy");
                
                string Text = Console.ReadLine();
                
                Console.WriteLine( 
                    FiggleFonts.Slant.Render(Text));
            }
            
            Console.WriteLine("------------------------");
            
            Thread.Sleep(1000);
            
            Console.WriteLine( 
                FiggleFonts.Slant.Render("Ok thanks oomfie"));
            Thread.Sleep(1000);
            System.Environment.Exit(1);
            
            
            


        }
    }
}