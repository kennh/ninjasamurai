using System;

namespace ConsoleApplication
{
    // Samurai should have a default health of 200
    // Samurai should have a method called death_blow, which when invoked should attack an object and decreases its health to 0 if it has less than 50 health
    // Samurai should have a method called meditate, which when invoked, heals the Samurai back to full health

    public class Samurai : Human
    { 
        public Samurai(string name, int str, int intel, int dex, int hp = 200) :base(name, str, intel, dex, hp)
        {
           
        }
         public void death_blow(Human obj)
            {
                if (obj.health < 50)
                {
                   obj.health = 0;
                }
            }
            public void meditate()
            {
                health = 200;
            }
    }
}