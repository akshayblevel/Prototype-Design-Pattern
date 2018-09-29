using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopy
{
    class ConcretePrototypeTopup : Prototype
    {
        public ConcretePrototypeTopup(string Ser, string Opr, string Cir, string Pro,Commission Comm)
            : base(Ser, Opr, Cir, Pro,Comm)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
