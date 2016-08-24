using System.Collections.Generic;

namespace BaseClasses
{
    public enum Element
    {
        Red,
        Blue,
        Green,
        Yellow,
        Black
    }

    public class RealBase
    {
        public RealBase()
        {

        }

        public RealBase(string name, string description, Dictionary<Element, int> damage)
        {
            this.damage = damage;
            this.name = name;
            this.description = description;
        }

        private string name, description;
        private Dictionary<Element, int> damage;

        public string Name { get; set; }

        public string Description { get; set; }

        public int GetDamageOfElement (Element el)
        {
            return this.damage[el];
        }

        public Dictionary<Element, int> Damage { get; set; }
    }

    public abstract class BaseSpell : RealBase
    {
        public int ManaCost { set; get; }
        public bool Avaible { set; get; }
        public int Weight { set; get; }
        
        public BaseSpell(string name, string description, Dictionary<Element, int> damage, int manaCost) : base(name, description, damage)
        {
            this.ManaCost = manaCost;
            this.Avaible = false;
        }

        public BaseSpell()
        {
            this.Avaible = false;
        }

        public abstract void ApplyEffect(BasePlayer enemy, BasePlayer spellUser);
    }

    public abstract class BaseGem : RealBase
    {
        public int Quantity { set; get; }

        public BaseGem(string name, string description, Dictionary<Element, int> damage) : base(name, description, damage)
        {
            this.Quantity = 0;
        }

        public BaseGem()
        {
            this.Quantity = 0;
        }

        public abstract void ApplyEffect(BasePlayer enemy, BasePlayer gemUser);
    }
}