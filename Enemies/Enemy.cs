using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    class Enemy
    {
        public int Health;
        public int HealthMax;
        public int Damage;
        public PictureBox Skin;
        
        public int Attack()
        {
            return Damage;
        }
        public void Attacked(int Damage)
        {
            Health = Health - Damage;
            if (Health <= 0)
            {
                Die();
            }
        }
        void Die()
        {
            Skin.Visible = false;
            Skin.Enabled = false;
        }
    }
}
