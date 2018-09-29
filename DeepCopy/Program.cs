using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                  Service    Operator    Circle    Provider     InComm  OutComm");
            Console.WriteLine("");
            ConcretePrototypeTopup CPT1 = new ConcretePrototypeTopup("Topup", "All", "Gujarat", "CyberPlat", new Commission(1.0, 0.5));

            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5} ", CPT1.Service, CPT1.Operator, CPT1.Circle, CPT1.Provider, CPT1.Comm.IncomingCommission, CPT1.Comm.OutgoingCommission);
            Console.WriteLine("");

            ConcretePrototypeTopup CPT2 = (ConcretePrototypeTopup)CPT1.Clone();

            Console.WriteLine("Deep Copy         {0}      {1}         {2}   {3}    {4}       {5}", CPT2.Service, CPT2.Operator, CPT2.Circle, CPT2.Provider, CPT2.Comm.IncomingCommission, CPT2.Comm.OutgoingCommission);
            Console.WriteLine("");

            CPT2.Circle = "Telengana";
            CPT2.Provider = "Euronet";
            CPT2.Comm.IncomingCommission = 0.75;
            CPT2.Comm.OutgoingCommission = 0.25;

            Console.WriteLine("Change Deep       {0}      {1}         {2}   {3}    {4}       {5}", CPT2.Service, CPT2.Operator, CPT2.Circle, CPT2.Provider, CPT2.Comm.IncomingCommission, CPT2.Comm.OutgoingCommission);
            Console.WriteLine("");
            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5}", CPT1.Service, CPT1.Operator, CPT1.Circle, CPT1.Provider, CPT1.Comm.IncomingCommission, CPT1.Comm.OutgoingCommission);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
