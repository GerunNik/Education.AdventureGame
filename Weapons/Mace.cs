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
        //public string Name;
        //public int Damage;
        //public PictureBox Skin;
        
        public List<Attack> AttackUp()
        {
            List<Attack> AttackPositions = new List<Attack>();

            Attack LeftAttack = new Attack
            {
                AttackPoint = HurtLeft()
            };
            Attack RightAttack = new Attack
            {
                AttackPoint = HurtRight()
            };
            Attack UpAttack = new Attack
            {
                AttackPoint = HurtUp()
            };
            AttackPositions.Add(LeftAttack);
            AttackPositions.Add(UpAttack);
            AttackPositions.Add(RightAttack);

            return AttackPositions;
        }
        public List<Attack> AttackDown()
        {
            List<Attack> AttackPositions = new List<Attack>();

            Attack LeftAttack = new Attack
            {
                AttackPoint = HurtLeft()
            };
            Attack DownAttack = new Attack
            {
                AttackPoint = HurtDown()
            };
            Attack RightAttack = new Attack
            {
                AttackPoint = HurtRight()
            };

            AttackPositions.Add(LeftAttack);
            AttackPositions.Add(DownAttack);
            AttackPositions.Add(RightAttack);

            return AttackPositions;
        }
        public List<Attack> AttackLeft()
        {
            List<Attack> AttackPositions = new List<Attack>();

            Attack LeftAttack = new Attack
            {
                AttackPoint = HurtLeft()
            };
            Attack UpAttack = new Attack
            {
                AttackPoint = HurtUp()
            };
            Attack DownAttack = new Attack
            {
                AttackPoint = HurtDown()
            };

            AttackPositions.Add(LeftAttack);
            AttackPositions.Add(UpAttack);
            AttackPositions.Add(DownAttack);

            return AttackPositions;
        }
        public List<Attack> AttackRight()
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
