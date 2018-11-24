using System;

namespace Lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Properties.Base _base = new Properties.Base();
            Properties.DerA A = new Properties.DerA();
            Properties.DerB B = new Properties.DerB();
            Properties.DerAB AB = new Properties.DerAB();

            _base.myname();
            A.myname();
            B.myname();
            AB.myname();
        }
    }
}
