// See https://aka.ms/new-console-template for more information
// File Methods in C#:
using System;
using System.IO;


class Program
{
  static void Main(string[] args)
  {

// string writeText="Hello World!"; // create a text string;
// File.WriteAllText("filename.txt",writeText); //Create a file and write the content of the writeText to it.



// using (StreamWriter sw= File.AppendText("filename.txt"))
// {
// sw.WriteLine("And now i am going to college");
// }
// // File.AppendText("filename.txt","And now i am going college");

// string readText = File.ReadAllText("filename.txt");
// Console.WriteLine(readText);



    // Making a copy of the file;
    string sourceFile="source.txt";
    string destinationFile = "destination.txt";

    File.WriteAllText(sourceFile,"This is the content of the source file.");

    File.Copy(sourceFile,destinationFile,overwrite:true);

    string copiedContent = File.ReadAllText(destinationFile);
    Console.WriteLine("Content of the destination file");
    Console.WriteLine(copiedContent);

  }
}


// There are few more methods in the file Ecosystem .Some of them are:


// File.SomeFileMethod();
