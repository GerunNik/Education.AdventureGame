using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Weapons
{
    class Sword : Weapon
    {
        public Sword()
        {
            Damage = 3;
            Name = "Sword";
        }
        public override List<Attack> AttackUp()
        {
            return GeneralAttack();
        }
        public override List<Attack> AttackDown()
        {
            return GeneralAttack();
        }
        public override List<Attack> AttackLeft()
        {
            return GeneralAttack();
        }
        public override List<Attack> AttackRight()
        {
            return GeneralAttack();
        }
        List<Attack> GeneralAttack()
        {
            List<Attack> AttackPositions = new List<Attack>();

            AttackPositions.Add(new Attack(HurtLeft()));
            AttackPositions.Add(new Attack(HurtDown()));
            AttackPositions.Add(new Attack(HurtUp()));
            AttackPositions.Add(new Attack(HurtRight()));

            return AttackPositions;
        }
    }
}
