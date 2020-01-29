using System;

namespace cSharpProves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            
            ReadFile readFile = new ReadFile();

            string path = @"c:\test\2020\";

            readFile.OpenFile(path); 
            
            
        }
    }
}
