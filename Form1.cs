using Adventure.Enemies;
using Adventure.Weapons;
using Adventure.Potions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure
{
    public partial class Form1 : Form
    {
        static Player Player = new Player();
        static List<Enemy> TheEnemies = new List<Enemy>();
        static List<Weapon> StuffOnGround = new List<Weapon>();
        static List<Turn> DefinedTurns = new List<Turn>();
        static List<Enemy> AllEnemies = new List<Enemy>();
        static int CurrentRound = 0;
        public Form1()
        {
            InitializeComponent();

            Player.Health = 15;
            Player.Skin = pictureBox3;

            FillStartInventory();
            DefineAllTurns();
            RoundClear();
        }

        void DefineAllTurns()
        {
            Turn stageOne = new Turn();
            stageOne.EnemiesToSpawn.Add(AllEnemies[0]);
            stageOne.EnemieSpawnPoints.Add(new Point(324, 94));

            stageOne.Player = Player;
            stageOne.PlayerStartPoint = new Point(74, 144);

            Turn stageTwo = new Turn();
            stageTwo.EnemiesToSpawn.Add(AllEnemies[1]);
            stageTwo.EnemieSpawnPoints.Add(new Point(324, 94));

            stageTwo.Player = Player;
            stageTwo.PlayerStartPoint = new Point(74, 144);

            Turn stageThree = new Turn();
            stageThree.EnemiesToSpawn.Add(AllEnemies[2]);
            stageThree.EnemieSpawnPoints.Add(new Point(324, 94));

            stageThree.Player = Player;
            stageThree.PlayerStartPoint = new Point(74, 144);

            Turn stageFour = new Turn();
            stageFour.EnemiesToSpawn.Add(AllEnemies[0]);
            stageFour.EnemieSpawnPoints.Add(new Point(324, 94));
            stageFour.EnemiesToSpawn.Add(AllEnemies[1]);
            stageFour.EnemieSpawnPoints.Add(new Point(324, 144));

            stageFour.Player = Player;
            stageFour.PlayerStartPoint = new Point(74, 144);

            Turn stageFive = new Turn();
            stageFive.EnemiesToSpawn.Add(AllEnemies[0]);
            stageFive.EnemieSpawnPoints.Add(new Point(324, 94));
            stageFive.EnemiesToSpawn.Add(AllEnemies[2]);
            stageFive.EnemieSpawnPoints.Add(new Point(324, 144));

            stageFive.Player = Player;
            stageFive.PlayerStartPoint = new Point(74, 144);

            Turn stageSix = new Turn();
            stageSix.EnemiesToSpawn.Add(AllEnemies[1]);
            stageSix.EnemieSpawnPoints.Add(new Point(324, 94));
            stageSix.EnemiesToSpawn.Add(AllEnemies[2]);
            stageSix.EnemieSpawnPoints.Add(new Point(324, 144));

            stageSix.Player = Player;
            stageSix.PlayerStartPoint = new Point(74, 144);

            Turn stageSeven = new Turn();
            stageSeven.EnemiesToSpawn.Add(AllEnemies[0]);
            stageSeven.EnemieSpawnPoints.Add(new Point(324, 94));
            stageSeven.EnemiesToSpawn.Add(AllEnemies[1]);
            stageSeven.EnemieSpawnPoints.Add(new Point(324, 144));
            stageSeven.EnemiesToSpawn.Add(AllEnemies[2]);
            stageSeven.EnemieSpawnPoints.Add(new Point(274, 144));

            stageSeven.Player = Player;
            stageSeven.PlayerStartPoint = new Point(74, 144);

            DefinedTurns.Add(stageOne);
            DefinedTurns.Add(stageTwo);
            DefinedTurns.Add(stageThree);
            DefinedTurns.Add(stageFour);
            DefinedTurns.Add(stageFive);
            DefinedTurns.Add(stageSix);
            DefinedTurns.Add(stageSeven);
        }

        private void WalkUp(object sender, EventArgs e)
        {
            Player.MoveUp();

            CheckGround();
        }

        private void WalkDown(object sender, EventArgs e)
        {
            Player.MoveDown();

            CheckGround();
        }

        private void WalkLeft(object sender, EventArgs e)
        {
            Player.MoveLeft();

            CheckGround();
        }

        private void WalkRight(object sender, EventArgs e)
        {
            Player.MoveRight();

            CheckGround();
        }
        void DrinkAPotion()
        {
            if (Player.EquippedWeapon is Potion)
            {
                Potion Potion = Player.EquippedWeapon as Potion;
                Potion.Use();
                EndTurn();
            }
        }

        private void AttackUp(object sender, EventArgs e)
        {
            if (Player.EquippedWeapon != null)
            {
                AttackPositions(Player.EquippedWeapon.AttackUp(), Player.EquippedWeapon.Damage);
                DrinkAPotion();
            }
        }

        private void AttackDown(object sender, EventArgs e)
        {
            if (Player.EquippedWeapon != null)
            {
                AttackPositions(Player.EquippedWeapon.AttackDown(), Player.EquippedWeapon.Damage);
                DrinkAPotion();
            }
        }

        private void AttackLeft(object sender, EventArgs e)
        {
            if (Player.EquippedWeapon != null)
            {
                AttackPositions(Player.EquippedWeapon.AttackLeft(), Player.EquippedWeapon.Damage);
                DrinkAPotion();
            }
        }

        private void AttackRight(object sender, EventArgs e)
        {
            if (Player.EquippedWeapon != null)
            {
                AttackPositions(Player.EquippedWeapon.AttackRight(), Player.EquippedWeapon.Damage);
                DrinkAPotion();
            }
        }

        void AttackPositions(List<Attack> attackedPositions, int Damage)
        {
            foreach (var item in attackedPositions)
            {
                foreach (var Enemy in TheEnemies)
                {
                    if (item.AttackPoint == Enemy.Skin.Location)
                    {
                        Enemy.Attacked(Damage);
                    }
                }
            }

            EndTurn();
        }
        void EndTurn()
        {
            int n = 0;
            foreach (var item in TheEnemies)
            {
                if (item.Health < 1)
                {
                    item.Skin.Visible = false;
                    item.Skin.Enabled = false;
                    TheEnemies.RemoveAt(n);
                    break;
                }
                n++;
            }

            foreach (var item in TheEnemies)
            {
                if (IsEnemyNearPlayer(item))
                {
                    Player.Health -= item.Attack();
                }
                else
                {
                    item.Move(Player.Skin.Location);
                    if (IsEnemyNearPlayer(item))
                    {
                        Player.Health -= item.Attack();
                    }
                }
            }

            ShowHealth();

            if (Player.Health < 1)
            {
                Player.Die();
                this.Close();
            }

            FillInventoryBox();
            RoundClear();
        }
        bool IsEnemyNearPlayer(Enemy item)
        {
            if (item.Skin.Location.X == Player.Skin.Location.X + 50 &&
                        item.Skin.Location.Y == Player.Skin.Location.Y ||
                        item.Skin.Location.X + 50 == Player.Skin.Location.X &&
                        item.Skin.Location.Y == Player.Skin.Location.Y ||
                        item.Skin.Location.Y + 50 == Player.Skin.Location.Y &&
                        item.Skin.Location.X == Player.Skin.Location.X ||
                        item.Skin.Location.Y == Player.Skin.Location.Y + 50 &&
                        item.Skin.Location.X == Player.Skin.Location.X)
            {
                return true;
            }
            return false;
        }
        void ShowHealth()
        {
            txtPlayerHealth.Text = Player.Health.ToString();
            txtBatHealth.Text = AllEnemies[0].Health.ToString();
            txtGhostHealth.Text = AllEnemies[1].Health.ToString();
            txtGhoulHealth.Text = AllEnemies[2].Health.ToString();
        }

        void CheckGround()
        {
            foreach (var item in StuffOnGround)
            {
                if (Player.Skin.Location == item.Skin.Location)
                {
                    Player.Inventory.Add(item);

                    if (Player.EquippedWeapon == null)
                    {
                        EquipWeapon(item.Name);
                    }

                    Point OutOfPicture = new Point(-100, -100);
                    item.Skin.Location = OutOfPicture;
                }
            }

            EndTurn();
        }

        void FillStartInventory()
        {
            Sword SwordWeapon = new Sword
            {
                Skin = PictureSword,
                PlayerSkin = Player.Skin
            };
            Bow BowWeapon = new Bow
            {
                Skin = PictureBow,
                PlayerSkin = Player.Skin
            };
            Mace MazeWeapon = new Mace
            {
                Skin = PictureMace,
                PlayerSkin = Player.Skin
            };

            Potion BluePotion = new Potion(Player, pictureBluePotion);
            BluePotion.Name = "BluePotion";
            BluePotion.HealingEffect = 5;
            Potion RedPotion = new Potion(Player, pictureRedPotion);
            RedPotion.Name = "RedPotion";
            RedPotion.HealingEffect = 3;
            RedPotion.Skin.Location = new Point(474, 194);
            BluePotion.Skin.Location = new Point(474, 44);

            Player.Inventory.Add(SwordWeapon);
            StuffOnGround.Add(BowWeapon);
            StuffOnGround.Add(MazeWeapon);
            StuffOnGround.Add(BluePotion);
            StuffOnGround.Add(RedPotion);

            Bat Bat = new Bat
            {
                Skin = PictureBat,
                Health = 6,
                Damage = 2,
                HealthMax = 6
            };
            Ghost Ghost = new Ghost
            {
                Skin = PictureGhost,
                Health = 8,
                Damage = 3,
                HealthMax = 8
            };
            Ghoul Ghoul = new Ghoul
            {
                Skin = PictureGhoul,
                Health = 10,
                Damage = 4,
                HealthMax = 10
            };

            AllEnemies.Add(Bat);
            AllEnemies.Add(Ghost);
            AllEnemies.Add(Ghoul);

            FillInventoryBox();
        }

        void FillInventoryBox()
        {
            Point spaceInInventory = new Point(74, 321);
            foreach (var item in Player.Inventory)
            {
                item.Skin.Location = spaceInInventory;
                if (item == Player.EquippedWeapon)
                {
                    item.Skin.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    item.Skin.BorderStyle = BorderStyle.None;
                }
                spaceInInventory.X += 50;
            }
        }

        void EquipWeapon(string nameOfWeapon)
        {
            foreach (var item in Player.Inventory)
            {
                if (item.Name == nameOfWeapon)
                {
                    Player.EquippedWeapon = item;
                    FillInventoryBox();
                }
            }
        }

        void RoundClear()
        {
            foreach (var item in AllEnemies)
            {
                bool match = false;

                foreach (var item2 in TheEnemies)
                {
                    if (item == item2)
                    {
                        match = true;
                    }
                }

                item.Skin.Visible = match;
                item.Skin.Enabled = match;
            }
            if (TheEnemies.Count < 1)
            {
                int i = 0;
                try
                {
                    foreach (var item in DefinedTurns[CurrentRound].EnemiesToSpawn)
                    {
                        TheEnemies.Add(item);
                        item.Health = item.HealthMax;
                        item.Skin.Location = DefinedTurns[CurrentRound].EnemieSpawnPoints[i];
                        i++;
                    }

                    Player.Skin.Location = DefinedTurns[CurrentRound].PlayerStartPoint;
                    CurrentRound++;
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    this.Close();
                }
                
            }
        }

        private void PictureSword_Click(object sender, EventArgs e)
        {
            EquipWeapon("Sword");
        }

        private void PictureBow_Click(object sender, EventArgs e)
        {
            EquipWeapon("Bow");
        }

        private void PictureMace_Click(object sender, EventArgs e)
        {
            EquipWeapon("Mace");
        }

        private void PictureBluePotion_Click(object sender, EventArgs e)
        {
            EquipWeapon("BluePotion");
        }

        private void PictureRedPotion_Click(object sender, EventArgs e)
        {
            EquipWeapon("RedPotion");
        }
    }
}
