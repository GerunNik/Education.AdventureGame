using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Turn
    {
        public Player Player = new Player();
        public Point PlayerStartPoint = new Point();

        public List<Enemy> EnemiesToSpawn = new List<Enemy>();
        public List<Point> EnemieSpawnPoints = new List<Point>();

        public List<Weapon> ItemsToSpawn = new List<Weapon>();
        public List<Point> ItemSpawnPoint = new List<Point>();
    }
}
