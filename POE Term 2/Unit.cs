using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Term_2
{
    public enum Direction { North, East, South, West}
    [Serializable]
    public abstract class Unit
    {
        protected int xPos;
        protected int yPos;
        protected int Health;
        protected int Speed;
        protected int Attack;
        protected int AttackRange;
        protected int Faction;
        protected string Symbol;
        protected string name;

        public Unit() { }
        abstract public void NewPos(Direction direction);
        abstract public void combatWithUnit(Unit u);
        abstract public bool withinAttackRange(Unit u);
        abstract public Unit UnitDistance(Unit[] units);
        abstract public bool isDead();
        abstract public string toString();
    }
}
