using System;

namespace seriy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        }
    }
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int Selery;

        public string GetFirstName() { return FirstName; }
        public string GetLastName() { return LastName; }
        public int GetSelery() { return Selery; }

        public void SetFirstName(string FirstName) { this.FirstName = FirstName; }
        public void SetLastName(string LastName) { this.LastName = LastName; }
        public void SetSelery(int Selery)
        {
            if (Selery >= 0)
                this.Selery = Selery;
        }

        public Employee()
        {
            FirstName = "Vasya";
            LastName = "Pupkin";
            Selery = 1000;
        }
    }
}
