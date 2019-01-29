using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Weapons
{
    class Bow : Weapon
    {
        public List<Attack> AttackUp()
        {
            List<Attack> AttackPositions = new List<Attack>();

            foreach (var item in HurtUp())
            {
                Attack UpAttack = new Attack
                {
                    AttackPoint = item
                };
                AttackPositions.Add(UpAttack);
            }

            return AttackPositions;
        }
        public List<Attack> AttackDown()
        {
            List<Attack> AttackPositions = new List<Attack>();

            foreach (var item in HurtDown())
            {
                Attack DownAttack = new Attack
                {
                    AttackPoint = item
                };
                AttackPositions.Add(DownAttack);
            }

            return AttackPositions;
        }
        public List<Attack> AttackLeft()
        {
            List<Attack> AttackPositions = new List<Attack>();

            foreach (var item in HurtLeft())
            {
                Attack LeftAttack = new Attack
                {
                    AttackPoint = item
                };
                AttackPositions.Add(LeftAttack);
            }

            return AttackPositions;
        }
        public List<Attack> AttackRight()
        {
            List<Attack> AttackPositions = new List<Attack>();
            
            foreach (var item in HurtRight())
            {
                Attack RightAttack = new Attack
                {
                    AttackPoint = item
                };
                AttackPositions.Add(RightAttack);
            }

            return AttackPositions;
        }
        List<Point> HurtUp()
        {
            List<Point> attackPoints = new List<Point>();
            for (int i = 0; i < 9; i++)
            {
                Point AttackPoint = new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y - (50 * i));
                attackPoints.Add(AttackPoint);
            }
            return attackPoints;
        }
        List<Point> HurtDown()
        {
            List<Point> attackPoints = new List<Point>();
            for (int i = 0; i < 9; i++)
            {
                Point AttackPoint = new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y + (50 * i));
                attackPoints.Add(AttackPoint);
            }
            return attackPoints;
        }
        List<Point> HurtLeft()
        {
            List<Point> attackPoints = new List<Point>();
            for (int i = 0; i < 9; i++)
            {
                Point AttackPoint = new Point(this.PlayerSkin.Location.X - (50 * i), this.PlayerSkin.Location.Y);
                attackPoints.Add(AttackPoint);
            }
            return attackPoints;
        }
        List<Point> HurtRight()
        {
            List<Point> attackPoints = new List<Point>();
            for (int i = 0; i < 9; i++)
            {
                Point AttackPoint = new Point(this.PlayerSkin.Location.X + (50 * i), this.PlayerSkin.Location.Y);
                attackPoints.Add(AttackPoint);
            }
            return attackPoints;
        }
    }
}
