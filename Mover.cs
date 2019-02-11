using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    abstract class Mover
    {
        public PictureBox Skin;
        public void MoveUp()
        {
            if (this.Skin.Location.Y != 44)
            {
                this.Skin.Top += -50;
            }
        }
        public void MoveDown()
        {
            if (this.Skin.Location.Y != 194)
            {
                this.Skin.Top += 50;
            }
        }
        public void MoveLeft()
        {
            if (this.Skin.Location.Y != 74)
            {
                this.Skin.Left += -50;
            }
        }
        public void MoveRight()
        {
            if (this.Skin.Location.Y != 474)
            {
                this.Skin.Left += 50;
            }
        }
        public virtual void Move(Point PlayerPosition)
        {

        }
    }
}
