using System;
using System.IO;

namespace Lab4.Properties
{
    public class CFile
    {
        private string path;
        private FileInfo fileinfo;
        private StreamWriter writer;
        private StreamReader reader;

        public void Open () {
            Console.WriteLine("Enter the path to the file");
            path = Console.ReadLine();

            reader = new StreamReader(path);
            fileinfo = new FileInfo(path);
            writer = new StreamWriter(path);
        } 
        public void Close () {
            fileinfo.Delete();
            writer.Close();
            reader.Close();
            path = "";
        }  

        public bool Seek (string Text) {
            return reader.ReadLine().Contains(Text);
        } 

        public void Read () {
            Console.WriteLine(reader.ReadLine());
        } 
        public void Write () {
            Console.WriteLine("Write text to enter in side of the file: \n");
            writer.Write(Console.ReadLine());
        } 

        public int GetPosition (string Text) {
            return reader.ReadLine().IndexOf(Text);
        } 
        public long GetLength () {
            return fileinfo.Length;
        } 
        public CFile()
        {
            Open();
        }
    }
}
