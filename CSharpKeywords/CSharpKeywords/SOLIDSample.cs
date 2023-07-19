using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRef
{
    public class SOLIDSample
    {

    }


    class Mammal
    {
        public Mammal(int vertebrae) { }

        public Mammal(Mammal mam) { }

        public virtual Mammal Clone()
        {
            return new Mammal(this);
        }
    }

    class Nerd : Mammal
    {
        public double Diopter { get; protected set; }
        public Nerd(int vertebrae, double diopter)
        : base(vertebrae) { Diopter = diopter; }
        protected Nerd(Nerd toBeCloned)
        : base(toBeCloned) { Diopter = toBeCloned.Diopter; }
        // Would prefer to return Nerd instead:
        public override Mammal Clone() { return new Nerd(this); }
        //public new Nerd Clone()
        //{
        //    return new Nerd(this);
        //}
    }

    public class Usage
    {
        public void Trigger()
        {
            Mammal Mam = new Nerd(0, 0);
            Mam.Clone(null);
        }
    }
}
