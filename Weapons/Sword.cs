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
        public List<Attack> AttackUp()
        {
            return GeneralAttack();
        }
        public List<Attack> AttackDown()
        {
            return GeneralAttack();
        }
        public List<Attack> AttackLeft()
        {
            return GeneralAttack();
        }
        public List<Attack> AttackRight()
        {
            return GeneralAttack();
        }
        List<Attack> GeneralAttack()
        {
            List<Attack> AttackPositions = new List<Attack>();

            Attack DownAttack = new Attack
            {
                AttackPoint = HurtDown()
            };
            Attack UpAttack = new Attack
            {
                AttackPoint = HurtUp()
            };
            Attack RightAttack = new Attack
            {
                AttackPoint = HurtRight()
            };
            Attack LeftAttack = new Attack
            {
                AttackPoint = HurtLeft()
            };

            AttackPositions.Add(LeftAttack);
            AttackPositions.Add(DownAttack);
            AttackPositions.Add(UpAttack);
            AttackPositions.Add(RightAttack);

            return AttackPositions;
        }
        Point HurtUp()
        {
            Point AttackPoint = new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y - 50);
            return AttackPoint;
        }
        Point HurtDown()
        {
            Point AttackPoint = new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y + 50);
            return AttackPoint;
        }
        Point HurtLeft()
        {
            Point AttackPoint = new Point(this.PlayerSkin.Location.X - 50, this.PlayerSkin.Location.Y);
            return AttackPoint;
        }
        Point HurtRight()
        {
            Point AttackPoint = new Point(this.PlayerSkin.Location.X + 50, PlayerSkin.Location.Y);
            return AttackPoint;
        }
    }
}
