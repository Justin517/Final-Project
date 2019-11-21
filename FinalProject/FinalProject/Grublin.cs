using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Grublin : Monster
    {
        public int Screech
        {
            get;

            set;
        }

        public Grublin () { }

        public Grublin(int health, bool hasweapon, int damage, int mana, int screech)
        {
            this.Health = health;
            this.HasWeapon = hasweapon;
            this.Damage = damage;
            this.Mana = mana;
            this.Screech = screech;

        }

        Grublin grublin = new Grublin(20, true, 5, 5, -1)
        {

        }
    }
}
