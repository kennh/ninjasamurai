using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wizard wizard = new Wizard("king", 56,78,  25, 50);
            wizard.fireball(wizard);
        }
    }
}
