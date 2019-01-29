using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    class Player
    {
        public int Health;
        public List<Weapon> Inventory = new List<Weapon>();
        public Weapon EquippedWeapon = new Weapon();
        public PictureBox Avatar;

        public void Attacked()
        {

        }
        public void TakeItem()
        {

        }
        public void Heal()
        {

        }
        public void Die()
        {
            Avatar.Visible = false;
        }
    }
}
