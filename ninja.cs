using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    // Ninja should have a default dexterity of 175
    // Ninja should have a steal method, which when invoked, attacks an object and increases the Ninjas health by 10
    // Ninja should have a get_away method, which when invoked, decreases its health by 15

    public class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int hp, int dex = 175) :base(name, str, intel, dex, hp)
        {
          
        }
        public void steal(object obj)
        {
            attack(obj);
            health += 10;
        }
        public void get_away()
        {
            health -= 15;
        }
    }
}