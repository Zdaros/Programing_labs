using System;
namespace Lab5.Properties
{
    public class DerAB : DerA//, DerB
    {
        public override void myname()
        {
            Console.WriteLine("DerAB");
        }
    }
}
