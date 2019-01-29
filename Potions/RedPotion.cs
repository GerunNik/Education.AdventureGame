using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure.Potions
{
    class RedPotion : Weapon, IPotion
    {
        int HealingEffect = 5;
        bool Used;
        Player Player;

        public RedPotion(Player protagonist, PictureBox newSkin)
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
