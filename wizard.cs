using System;
using System.Collections.Generic;  

namespace ConsoleApplication
{
    // Wizard should have a default health of 50 and intelligence of 25
    // Wizard should have a method called heal, which when invoked, heals the Wizard by 10 * intelligence
    // Wizard should have a method called fireball, which when invoked, decreases the health of whichever object it attacked by some random integer between 20 and 50

    public class Wizard : Human
    {
        public Wizard(string name, int str,int dex, int intel = 25, int hp = 50) : base(name, str, intel, dex, hp)
        {
            
        }
        public void heal()
            {
               intelligence *= 10;
            }
            public void fireball(Human obj)
            {
               // (obj);
              
                Random rand = new Random();
               obj.health -= rand.Next(20,50);
               System.Console.WriteLine(obj.health);
            }

    }
}