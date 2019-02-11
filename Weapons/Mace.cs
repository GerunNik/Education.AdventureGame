using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Weapons
{
    public class Mace : Weapon
    {
        public Mace()
        {
            Damage = 5;
            Name = "Mace";
        }
        public override List<Attack> AttackUp()
        {
            List<Attack> AttackPositions = new List<Attack>();

            AttackPositions.Add(new Attack(HurtLeft()));
            AttackPositions.Add(new Attack(HurtUp()));
            AttackPositions.Add(new Attack(HurtRight()));

            return AttackPositions;
        }
        public override List<Attack> AttackDown()
        {
            List<Attack> AttackPositions = new List<Attack>();

            AttackPositions.Add(new Attack(HurtDown()));
            AttackPositions.Add(new Attack(HurtLeft()));
            AttackPositions.Add(new Attack(HurtRight()));

            return AttackPositions;
        }
        public override List<Attack> AttackLeft()
        {
            List<Attack> AttackPositions = new List<Attack>();

            AttackPositions.Add(new Attack(HurtDown()));
            AttackPositions.Add(new Attack(HurtUp()));
            AttackPositions.Add(new Attack(HurtLeft()));

            return AttackPositions;
        }
        public override List<Attack> AttackRight()
        {
            List<Attack> AttackPositions = new List<Attack>();

            AttackPositions.Add(new Attack(HurtDown()));
            AttackPositions.Add(new Attack(HurtUp()));
            AttackPositions.Add(new Attack(HurtRight()));

            return AttackPositions;
        }
    }
}
