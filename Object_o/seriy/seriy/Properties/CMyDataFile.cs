using System;
namespace Lab4.Properties
{
    public class CMyDataFile : CFile
    {
        private MyData data = new MyData();

        private void SetData () {
            Console.WriteLine("Set name: ");
            data.Name = Console.ReadLine();
        }
        private void GetData()
        {
            Console.WriteLine("Name is " + data.Name);
        }

        public CMyDataFile()
        {
            SetData();
            GetData();
        }
    }
}
