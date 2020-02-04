using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class ReadFile

{
    public List<string> ListFile = new List<string>();

    public void OpenFile(String path)
    {
        
        string[] fileNames = Directory.GetFiles(path);
        

        //System.IO.File.ReadAllText(@"C:\test\2020\test.txt");

        //System.Console.WriteLine("te = " + file.Replace("prova","hola"));
        foreach(string fileName in fileNames){
            //System.Console.WriteLine(fileName);
            ListFile.Add(fileName);

        }

        string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach(string subdirectory in subdirectoryEntries)
            OpenFile(subdirectory);
        



    }
}