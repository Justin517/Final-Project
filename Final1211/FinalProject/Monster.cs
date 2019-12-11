using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Monster
    {
        public int Health
        {
            get;

            set;
        }
        public bool HasWeapon
        {
            get;

            set;
        }
        public int Damage
        {
            get;

            set;
        }
        public void MonsterAttack(ref Player player)
        {
            player.PlayerHealth -= Damage;
        }

    }
}
