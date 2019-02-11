using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    public class Weapon
    {
        public string Name;
        public int Damage;
        public PictureBox Skin;
        public PictureBox PlayerSkin;

        public virtual List<Attack> AttackDown()
        {
            return new List<Attack>();
        }
        public virtual List<Attack> AttackUp()
        {
            return new List<Attack>();
        }
        public virtual List<Attack> AttackLeft()
        {
            return new List<Attack>();
        }
        public virtual List<Attack> AttackRight()
        {
            return new List<Attack>();
        }

        public Point HurtUp()
        {
            return new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y - 50);
        }
        public Point HurtDown()
        {
            return new Point(this.PlayerSkin.Location.X, this.PlayerSkin.Location.Y + 50);
        }
        public Point HurtLeft()
        {
            return new Point(this.PlayerSkin.Location.X - 50, this.PlayerSkin.Location.Y);
        }
        public Point HurtRight()
        {
            return new Point(this.PlayerSkin.Location.X + 50, PlayerSkin.Location.Y);
        }
    }
}
