using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace cSharpProves
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            int counter = 0;  
            string line;  
            
            ReadFile readFile = new ReadFile();

            string path = @"c:\test\2020\";

            readFile.OpenFile(path);

            string[] files = readFile.ListFile.ToArray(); 

            Parallel.ForEach(files,(currentFile) => {
                System.Console.WriteLine(currentFile);
                
                System.IO.StreamReader file = new System.IO.StreamReader(currentFile);

             
                while((line = file.ReadLine()) != null)  
                {  
                    System.Console.WriteLine(line);  
                    counter++;  
                }  
  
                file.Close();  
                System.Console.WriteLine("There were {0} lines.", counter);  
                // Suspend the screen.  
                //System.Console.ReadLine();  
            });

            
          
 
            
        }
    }
}
