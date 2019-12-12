using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Player
    {
        public int PlayerHealth = 100;

        public string Name
        {
            get;

            set;
        }
        public int StandardDamage = 5;

        public int StandardDefend = 2;

        public Player(string name)
        {
            this.Name = name;
        }
        public void Attack(ref Monster monster)
        {
            monster.Health -= StandardDamage;
        }

    }

    
}
