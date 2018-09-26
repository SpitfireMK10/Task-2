using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Term_2
{
    [Serializable]
    class ResourceBuilding : Building
    {
        public int Xpos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int Ypos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public int health
        {
            get { return Health; }
            set { Health = value; }
        }

        public int faction
        {
            get { return Faction; }
            set { Faction = value; }
        }

        public string symbol
        {
            get { return Symbol; }
            set { Symbol = value; }
        }

        private string resourceType;

        public string ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

        private int resourcePerGameTick;

        public int ResourcePerGameTick
        {
            get { return resourcePerGameTick; }
            set { resourcePerGameTick = value; }
        }

        private int resourcesRemaining;

        public int ResourcesRemaining
        {
            get { return resourcesRemaining; }
            set { resourcesRemaining = value; }
        }

        public ResourceBuilding(int X_position, int Y_position, int Health, int Faction1, string Symbol1, string resource, int productionRate, int remaining) // this is the constructor for the resource building
        {
            Xpos = X_position;
            Ypos = Y_position;
            health = Health;
            faction = Faction1;
            symbol = Symbol1;
            ResourceType = resource;
            ResourcePerGameTick = productionRate;
            ResourcesRemaining = remaining;
        }

        public override bool isDead() // this will return true if the building has been destroyed
        {
            if (Health < 1)
            {
                return true;
            }
            else

                return false;
        }

        public override string toString()
        {
            return "Resource Building: " + "\r\nX Position: " + Xpos + "\r\nY Position: " + Ypos + "\r\nHealth: " + Health + "\r\nFaction " + Faction + "\r\nSymbol: " + Symbol + "\r\nResource Type: " + ResourceType + "\r\nResource Per Game Tick: " + ResourcePerGameTick + "\r\nResources Remaining: " + ResourcesRemaining;
        }

        public void ResourceGenerate() // this will detuct the resources from the mine
        {
            ResourcesRemaining = ResourcesRemaining - resourcePerGameTick;      
        }

    }
}
