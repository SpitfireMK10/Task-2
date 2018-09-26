using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace POE_Term_2
{
    [Serializable]
    public class Map
    {
        private Unit[] units;
        private Building[] buildings;
        Random r = new Random();

        public Unit[] Units
        {
            get { return units; }
            set { units = value; }
        }

        public Building[] Buildings
        {
            get { return buildings; }
            set { buildings = value; }
        }

        public Map(int maxX, int maxY, int numUnits , int numBuildings)
        {
            int buildingX, buildingY;
            units = new Unit[numUnits];
            buildings = new Building[numBuildings];
            for (int i = 0; i < numUnits; i++)
            {
                if (i <= 10)
                {
                    MeleeUnit M = new MeleeUnit(r.Next(0, maxX), r.Next(0, maxY), r.Next(10, 20) * 10, r.Next(5, 20), 1, 1, i % 2, "M", "Knight");         // these will create the archer and melee units and place them within the units array           
                    Units[i] = M;
                }

                if (i > 10)
                {
                    RangedUnit R = new RangedUnit(r.Next(0, maxX), r.Next(0, maxY), r.Next(10, 20) * 10, r.Next(5, 20), 1, 1, i % 2, "R", "Archer");
                    Units[i] = R;
                }
            }

            for (int i =0; i<numBuildings; i++)
            {
                if(i<=5)
                {
                    buildingX = r.Next(0, maxX);
                    buildingY = r.Next(0, maxX);
                    FactoryBuilding fb = new FactoryBuilding(buildingX, r.Next(0, maxY), r.Next(5, 10) * 10, i % 2, "FB", r.Next(0, 1), r.Next(5, 10), buildingX + 1, buildingY +1); // these will create the buildings that will then be put into the buildings array 
                    Buildings[i] = fb;
                }

                if (i>5)
                {
                    ResourceBuilding rb = new ResourceBuilding(r.Next(0, maxX), r.Next(0, maxY), r.Next(5, 10) * 10, i%2, "RB", "Gold", r.Next(5,15), r.Next(100,400));
                    Buildings[i] = rb;
                }
            }




        }
    }
}

