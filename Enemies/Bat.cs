using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Bat : Enemy
    {
        public void Move(Point PlayerPosition)
        {
            Random r = new Random();
            int directionNumber = r.Next(1, 4);

            if (PlayerPosition.X < this.Skin.Location.X)
            {
                //Go Left
                if (directionNumber == 1)
                {
                    if (this.Skin.Location.Y != 44)
                    {
                        this.Skin.Top += -50;
                    }
                    else
                    {
                        this.Skin.Top += 50;
                    }
                }
                else if (directionNumber == 2)
                {
                    if (this.Skin.Location.Y != 194)
                    {
                        this.Skin.Top += 50;
                    }
                    else
                    {
                        this.Skin.Top += -50;
                    }
                }
                else if (directionNumber == 3)
                {
                    if (this.Skin.Location.X != 474)
                    {
                        this.Skin.Left += -50;
                    }
                    else
                    {
                        this.Skin.Left += 50;
                    }
                }
            }
            else if(PlayerPosition.X > this.Skin.Location.X)
            {
                //Go Right
                if (directionNumber == 1)
                {
                    if (this.Skin.Location.Y != 44)
                    {
                        this.Skin.Top += -50;
                    }
                    else
                    {
                        this.Skin.Top += 50;
                    }
                }
                else if (directionNumber == 2)
                {
                    if (this.Skin.Location.Y != 194)
                    {
                        this.Skin.Top += 50;
                    }
                    else
                    {
                        this.Skin.Top += -50;
                    }
                }
                else if (directionNumber == 3)
                {
                    if (this.Skin.Location.X != 474)
                    {
                        this.Skin.Left += 50;
                    }
                    else
                    {
                        this.Skin.Left += -50;
                    }
                }
            }
            else
            {
                if (PlayerPosition.Y > this.Skin.Location.Y)
                {
                    if (this.Skin.Location.Y != 44)
                    {
                        this.Skin.Top += -50;
                    }
                    else
                    {
                        this.Skin.Top += 50;
                    }
                }
                else
                {
                    if (this.Skin.Location.Y != 194)
                    {
                        this.Skin.Top += 50;
                    }
                    else
                    {
                        this.Skin.Top += -50;
                    }
                }
            }
        }
    }
}
