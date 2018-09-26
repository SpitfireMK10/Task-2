using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Term_2
{
    [Serializable]
    public abstract class Building
    {
        protected int xPos;
        protected int yPos;
        protected int Health;
        protected int Faction;
        protected string Symbol;

        public Building() { }
        abstract public bool isDead();
        abstract public string toString();



    }
}
