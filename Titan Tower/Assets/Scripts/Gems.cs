using System.Collections;
using BaseClasses;
using System;
using System.Collections.Generic;

namespace GemsCollection
{
    public class Gems
    {
        public List<BaseGem> Items;
        private BaseGem BlackGem, BlueGem, GreenGem, WhiteGem, YellowGem, RedGem;
        
        public Gems()
        {
            Items = new List<BaseGem>();

            this.BlackGem = new BlackGem();
            this.BlueGem = new BlueGem();
            this.GreenGem = new GreenGem();
            this.WhiteGem = new WhiteGem();
            this.YellowGem = new YellowGem();
            this.RedGem = new RedGem();

            Items.Add(BlackGem);
            Items.Add(BlueGem);
            Items.Add(GreenGem);
            Items.Add(WhiteGem);
            Items.Add(YellowGem);
            Items.Add(RedGem);
        }



        public BaseGem GemByColor(Element el)
        {
            switch (el)
            {
                case Element.Black:
                    return BlackGem;
                case Element.Blue:
                    return BlueGem;
                case Element.Green:
                    return GreenGem;
                case Element.Red:
                    return RedGem;
                default:
                    return YellowGem;
            }
        }

        public void Add(Element e)
        {
            GemByColor(e).Quantity++;
        }

        public void Sub(Element e)
        {
            GemByColor(e).Quantity--;
        }
    }

    public class RedGem : BaseGem{
        public RedGem()
        {
            base.Quantity = 0;
            base.Name = "Gema vermelhor.";
            base.Description = "Gema vermelha viva, quente ao toque. Protege de danos de feitiços flamejantes.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 0);
            damage.Add(Element.Blue, 0);
            damage.Add(Element.Green, 0);
            damage.Add(Element.Yellow, 0);
            damage.Add(Element.Red, 50); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< TODO
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }

    public class BlueGem : BaseGem
    {
        public BlueGem()
        {
            base.Quantity = 0;
            base.Name = "Gema Azul.";
            base.Description = "Gema azul, parece preenchida por um líquido. Protege de danos de feitiços com água.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 0);
            damage.Add(Element.Blue, 50); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< TODO
            damage.Add(Element.Green, 0);
            damage.Add(Element.Yellow, 0);
            damage.Add(Element.Red, 0); 
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }

    public class BlackGem : BaseGem
    {
        public BlackGem()
        {
            base.Quantity = 0;
            base.Name = "Gema Negra.";
            base.Description = "Gema negra, preenchida com a alma de criatura mortas. Protege de danos de feitiços de trevas.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 50);//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< TODO
            damage.Add(Element.Blue, 0); 
            damage.Add(Element.Green, 0);
            damage.Add(Element.Yellow, 0);
            damage.Add(Element.Red, 0);
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }

    public class GreenGem : BaseGem
    {
        public GreenGem()
        {
            base.Quantity = 0;
            base.Name = "Gema Verde.";
            base.Description = "Gema verde, agradável ao toque. Protege de danos de feitiços da natureza.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 0);
            damage.Add(Element.Blue, 0);
            damage.Add(Element.Green, 50); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< TODO
            damage.Add(Element.Yellow, 0);
            damage.Add(Element.Red, 0);
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }

    public class WhiteGem : BaseGem
    {
        public WhiteGem()
        {
            base.Quantity = 0;
            base.Name = "Gema Branca.";
            base.Description = "Gema branca, levemente fria ao toque e muito leve. Protege de danos de feitiços de vento.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 0);
            damage.Add(Element.Blue, 0);
            damage.Add(Element.Green, 0); 
            damage.Add(Element.Yellow, 0);
            damage.Add(Element.Red, 0);
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }

    public class YellowGem : BaseGem
    {
        public YellowGem()
        {
            base.Quantity = 0;
            base.Name = "Gema amarela.";
            base.Description = "Gema amarela, causa sensação de bem estar e acalma o espirito. Protege contra feitiços sagrados.";

            Dictionary<Element, int> damage = new Dictionary<Element, int>();
            damage.Add(Element.Black, 0);
            damage.Add(Element.Blue, 0);
            damage.Add(Element.Green, 0); 
            damage.Add(Element.Yellow, 50); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< TODO
            damage.Add(Element.Red, 0);
        }

        public override void ApplyEffect(BasePlayer enemy, BasePlayer gemUser)
        {
            throw new NotImplementedException();
        }
    }
}