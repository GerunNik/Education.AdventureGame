using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Ghoul : Enemy
    {
        public void Move(Point PlayerPosition)
        {
            Random r = new Random();
            int moveOrNot = r.Next(1, 4);
            int directionNumber = r.Next(1, 3);

            if (moveOrNot < 3)
            {
                if (PlayerPosition.X < this.Skin.Location.X)
                {
                    if (directionNumber == 1)
                    {
                        if (PlayerPosition.X < this.Skin.Location.X)
                        {
                            this.Skin.Left += -50;
                        }
                        else if (PlayerPosition.X > this.Skin.Location.X)
                        {
                            this.Skin.Left += 50;
                        }
                        else
                        {
                            if (PlayerPosition.Y < this.Skin.Location.Y)
                            {
                                this.Skin.Top += -50;
                            }
                            else if (PlayerPosition.Y > this.Skin.Location.Y)
                            {
                                this.Skin.Top += 50;
                            }
                        }
                    }
                    else if (directionNumber == 2)
                    {
                        if (PlayerPosition.Y < this.Skin.Location.Y)
                        {
                            this.Skin.Top += -50;
                        }
                        else if (PlayerPosition.Y > this.Skin.Location.Y)
                        {
                            this.Skin.Top += 50;
                        }
                        else
                        {
                            if (PlayerPosition.X < this.Skin.Location.X)
                            {
                                this.Skin.Left += -50;
                            }
                            else if (PlayerPosition.X > this.Skin.Location.X)
                            {
                                this.Skin.Left += 50;
                            }
                        }
                    }
                }
                else if (PlayerPosition.X > this.Skin.Location.X)
                {
                    //Go Right
                    if (directionNumber == 1)
                    {
                        this.Skin.Top += 50;
                    }
                    else if (directionNumber == 2)
                    {
                        this.Skin.Top += -50;
                    }
                    else if (directionNumber == 3)
                    {
                        this.Skin.Left += 50;
                    }
                }
                else
                {
                    if (PlayerPosition.Y > this.Skin.Location.Y)
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
