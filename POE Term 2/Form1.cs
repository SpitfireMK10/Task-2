using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace POE_Term_2
{
    
    public partial class Form1 : Form
    {
        int Turn = 0;
        Random r = new Random();
        Map map = new Map(20, 20, 20 , 10);

        const int SIZE = 45;
        public Form1()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMap();
            DisplayMap();
            txtTimer.Text = (++Turn).ToString();
        }


        private void DisplayMap() // this is the method that will erease and update the game map 
        {
            groupDisplay.Controls.Clear();
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    MeleeUnit m = (MeleeUnit)u;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.Xpos * SIZE), start_Y + (m.Ypos * SIZE));
                    But.Text = m.symbol;
                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }

            }
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    RangedUnit m = (RangedUnit)u;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.Xpos * SIZE), start_Y + (m.Ypos * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }

            }

            foreach(Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    FactoryBuilding m = (FactoryBuilding)b;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.Xpos * SIZE), start_Y + (m.Ypos * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(ResourceBuilding))
                {
                    int start_x = 20;
                    int start_Y = 20;
                    start_x = groupDisplay.Location.X;
                    start_Y = groupDisplay.Location.Y;
                    ResourceBuilding m = (ResourceBuilding)b;
                    Button But = new Button();

                    But.Size = new Size(SIZE, SIZE);
                    But.Location = new Point(start_x + (m.Xpos * SIZE), start_Y + (m.Ypos * SIZE));
                    But.Text = m.symbol;

                    if (m.faction == 1)
                    {
                        But.ForeColor = Color.Red;
                    }
                    else
                    {
                        But.ForeColor = Color.Blue;
                    }
                    if (m.isDead())
                    {
                        m.symbol = "X";
                        But.Text = "X";
                    }
                    groupDisplay.Controls.Add(But);
                    But.Click += new EventHandler(Button_Click);
                }
            }
        }

        private void UpdateMap()// this will cycle through all the units and buildisngs to see if they need to move and whether or not they have been killed in combat
        {
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    MeleeUnit m = (MeleeUnit)u;
                    if (m.health > 1)
                    {
                        if (m.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: ((MeleeUnit)u).NewPos(Direction.North); break;
                                case 1: ((MeleeUnit)u).NewPos(Direction.East); break;
                                case 2: ((MeleeUnit)u).NewPos(Direction.South); break;
                                case 3: ((MeleeUnit)u).NewPos(Direction.West); break;
                            }
                        }
                        else
                        {
                            bool inCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.withinAttackRange(e))
                                {
                                    u.combatWithUnit(e);
                                    inCombat = true;
                                }
                            }
                            if (!inCombat)
                            {
                                Unit c = u.UnitDistance(map.Units);
                                m.NewPos(m.Directionto(c));
                            }
                        }
                    }
                    else
                    {
                        m.symbol = "X";
                    }
                }

                
            }
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit m = (RangedUnit)u;
                    if (m.health > 1)
                    {
                        if (m.health < 25)
                        {
                            switch (r.Next(0, 4))
                            {
                                case 0: ((RangedUnit)u).NewPos(Direction.North); break;
                                case 1: ((RangedUnit)u).NewPos(Direction.East); break;
                                case 2: ((RangedUnit)u).NewPos(Direction.South); break;
                                case 3: ((RangedUnit)u).NewPos(Direction.West); break;
                            }
                        }
                        else
                        {
                            bool inCombat = false;
                            foreach (Unit e in map.Units)
                            {
                                if (u.withinAttackRange(e))
                                {
                                    u.combatWithUnit(e);
                                    inCombat = true;
                                }
                            }
                            if (!inCombat)
                            {
                                Unit c = u.UnitDistance(map.Units);
                                m.NewPos(m.Directionto(c));
                            }
                        }
                    }
                    else
                    {
                        m.symbol = "X";
                    }
                }
            }

            foreach(Building b in map.Buildings)
            {
                if(b.GetType() == typeof(ResourceBuilding))
                {
                    ResourceBuilding rb = (ResourceBuilding)b;
                    rb.ResourceGenerate();
                }
            }

            foreach (Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    FactoryBuilding fb = (FactoryBuilding)b;
                }
            }
            #region SpawningOfUnits   
            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(MeleeUnit))
                {
                    MeleeUnit mu = (MeleeUnit)u;
                    if (mu.symbol == "X")
                    {
                        int faction = mu.faction;
                        int rand = r.Next(0, 5);
                        FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
                        fb.Spawner(20, 20, faction);
                    }
                }
            }

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit mu = (RangedUnit)u;
                    if (mu.symbol == "X")
                    {
                        int faction = mu.faction;
                        int rand = r.Next(0, 5);
                        FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
                        fb.Spawner(20, 20, faction);
                    }
                }
            }
            #endregion
        }

        public void Button_Click(object sender, EventArgs args) // this will see what button has been clicked and then display the information of that specific unit
        {
            int x = (((Button)sender).Location.X - groupDisplay.Location.X) / SIZE;
            int Y = (((Button)sender).Location.Y - groupDisplay.Location.Y) / SIZE;

            foreach (Unit u in map.Units)
            {
                if (u.GetType() == typeof(RangedUnit))
                {
                    RangedUnit r = (RangedUnit)u;

                    if(r.Xpos == x && r.Ypos == Y)
                    {
                        txtDisplay.Text = "" + r.toString();
                    }
                }

                else if(u.GetType() == typeof(MeleeUnit))
                {
                    MeleeUnit m = (MeleeUnit)u;

                    if (m.Xpos == x && m.Ypos == Y)
                    {
                        txtDisplay.Text = "" + m.toString();
                    }
                }
            }

            foreach(Building b in map.Buildings)
            {
                if (b.GetType() == typeof(FactoryBuilding))
                {
                    FactoryBuilding fb = (FactoryBuilding)b;

                    if (fb.Xpos == x && fb.Ypos == Y)
                    {
                        txtDisplay.Text = "" + fb.toString();
                    }
                }

                else if (b.GetType() == typeof(ResourceBuilding))
                {
                    ResourceBuilding rb = (ResourceBuilding)b;

                    if (rb.Xpos == x && rb.Ypos == Y)
                    {
                        txtDisplay.Text = "" + rb.toString();
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e) // when clicked this button will save the game
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("GameSave.bat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, map);
                    MessageBox.Show("Game Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) // this button will load the previously saved game
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("GameSave.bat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                        map = (Map)bf.Deserialize(fsin);                   
                        MessageBox.Show("Game Successfully Loaded");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            UpdateMap();
            DisplayMap();
        }

        private void groupDisplay_Enter(object sender, EventArgs e)
        {

        }
    }
}
