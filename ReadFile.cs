using System;
using System.IO;
using System.Text;

class ReadFile

{
    public void OpenFile(String path)
    {
        
        string[] fileNames = Directory.GetFiles(path);
        

        //System.IO.File.ReadAllText(@"C:\test\2020\test.txt");

        //System.Console.WriteLine("te = " + file.Replace("prova","hola"));
        foreach(string fileName in fileNames)
            System.Console.WriteLine(fileName);


        string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach(string subdirectory in subdirectoryEntries)
            OpenFile(subdirectory);
        



    }
}