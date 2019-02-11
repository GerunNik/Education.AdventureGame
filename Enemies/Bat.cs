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
        public override void Move(Point PlayerPosition)
        {
            Random r = new Random();
            int directionNumber = r.Next(1, 4);

            if (PlayerPosition.X < this.Skin.Location.X)
            {
                switch (directionNumber)
                {
                    case 1:
                        MoveLeft();
                        break;

                    case 2:
                        MoveUp();
                        break;

                    case 3:
                        MoveDown();
                        break;
                }
            }
            else if(PlayerPosition.X > this.Skin.Location.X)
            {
                switch (directionNumber)
                {
                    case 1:
                        MoveRight();
                        break;

                    case 2:
                        MoveUp();
                        break;

                    case 3:
                        MoveDown();
                        break;
                }
            }
            else
            {
                if (PlayerPosition.Y > this.Skin.Location.Y)
                {
                    MoveDown();
                }
                else
                {
                    MoveUp();
                }
            }
        }
    }
}
