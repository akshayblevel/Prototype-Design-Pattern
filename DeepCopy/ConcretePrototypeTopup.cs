using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class ConcretePrototypeTopup : Prototype 
    {
        public ConcretePrototypeTopup(string Ser, string Opr, string Cir, string Pro,Commission Comm)
            : base(Ser, Opr, Cir, Pro,Comm)
        {

        }

        public override Prototype Clone()
        {
            ConcretePrototypeTopup objCPT = (ConcretePrototypeTopup)this.MemberwiseClone();
            //objCPT.Comm = (Commission)this.Comm.Clone();
            objCPT.Comm = new Commission(Comm.IncomingCommission,Comm.OutgoingCommission);
            objCPT.Comm.IncomingCommission = this.Comm.IncomingCommission;
            objCPT.Comm.OutgoingCommission = this.Comm.OutgoingCommission;
            return objCPT;
        }

        
    }
}
