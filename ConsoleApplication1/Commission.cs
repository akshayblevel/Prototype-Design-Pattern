using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Commission
    {
        public double IncomingCommission;
        public double OutgoingCommission;

        public Commission(double IncomingComm,double OutgoingComm)
        {
            this.IncomingCommission = IncomingComm;
            this.OutgoingCommission = OutgoingComm;
        }
    }
}
