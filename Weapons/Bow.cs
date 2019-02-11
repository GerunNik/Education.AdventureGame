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
        public Bow()
        {
            Damage = 1;
            Name = "Bat";
        }
        public override List<Attack> AttackUp()
        {
            return PierceThrough("Up");
        }
        public override List<Attack> AttackDown()
        {
            return PierceThrough("Down");
        }
        public override List<Attack> AttackLeft()
        {
            return PierceThrough("Left");
        }
        public override List<Attack> AttackRight()
        {
            return PierceThrough("Right");
        }

        List<Attack> PierceThrough(string direction)
        {
            List<Attack> FlightRoute = new List<Attack>();

            switch (direction)
            {
                case "Up":
                    for (int i = 0; i < 9; i++)
                    {
                        FlightRoute.Add(new Attack(new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y - (50 * i))));
                    }
                    break;

                case "Down":
                    for (int i = 0; i < 9; i++)
                    {
                        FlightRoute.Add(new Attack(new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y + (50 * i))));
                    }
                    break;

                case "Right":
                    for (int i = 0; i < 9; i++)
                    {
                        FlightRoute.Add(new Attack(new Point(this.PlayerSkin.Location.X + (50 * i), this.PlayerSkin.Location.Y)));
                    }
                    break;

                case "Left":
                    for (int i = 0; i < 9; i++)
                    {
                        FlightRoute.Add(new Attack(new Point(this.PlayerSkin.Location.X - (50 * i), this.PlayerSkin.Location.Y)));
                    }
                    break;
            }

            return FlightRoute;
        }
    }
}
