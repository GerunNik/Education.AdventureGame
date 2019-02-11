using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Potions
{
    class Potion : Weapon, IPotion
    {
        public int HealingEffect { get; set; }
        bool Used;
        Player Player;

        public Potion(Player protagonist, PictureBox newSkin)
        {
            Used = false;
            Player = protagonist;
            Skin = newSkin;
        }

        public void Use()
        {
            if (Used == true)
            {
                Player.Health += HealingEffect;
            }
            else
            {
                Player.Health += HealingEffect;
                Used = true;
                HealingEffect = 1;
            }
        }
    }
}