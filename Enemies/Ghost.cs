using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Enemies
{
    class Ghost : Enemy
    {
        public override void Move(Point PlayerPosition)
        {
            Random r = new Random();
            int moveOrNot = r.Next(1, 4);
            int directionNumber = r.Next(1, 3);

            if (moveOrNot == 1)
            {
                if (directionNumber == 1)
                {
                    if (PlayerPosition.X < this.Skin.Location.X)
                    {
                        MoveLeft();
                    }
                    else if (PlayerPosition.X > this.Skin.Location.X)
                    {
                        MoveRight();
                    }
                    else
                    {
                        if (PlayerPosition.Y < this.Skin.Location.Y)
                        {
                            MoveUp();
                        }
                        else if (PlayerPosition.Y > this.Skin.Location.Y)
                        {
                            MoveDown();
                        }
                    }
                }
                else if (directionNumber == 2)
                {
                    if (PlayerPosition.Y < this.Skin.Location.Y)
                    {
                        MoveUp();
                    }
                    else if (PlayerPosition.Y > this.Skin.Location.Y)
                    {
                        MoveDown();
                    }
                    else
                    {
                        if (PlayerPosition.X < this.Skin.Location.X)
                        {
                            MoveLeft();
                        }
                        else if (PlayerPosition.X > this.Skin.Location.X)
                        {
                            MoveRight();
                        }
                    }
                }
            }
        }
    }
}
