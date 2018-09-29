using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                  Service    Operator    Circle    Provider     InComm  OutComm");
            Console.WriteLine("");
            
            Prototype CPT1 = new Prototype("Topup", "All", "Gujarat", "CyberPlat", new Commission(1.0, 0.5));
            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5} ", CPT1.Service, CPT1.Operator, CPT1.Circle, CPT1.Provider, CPT1.Comm.IncomingCommission, CPT1.Comm.OutgoingCommission);
            
            Console.WriteLine("");

            Prototype CPT2 = new Prototype("Topup", "All", "Telengana", "Euronet", new Commission(0.75, 0.25));
            Console.WriteLine("Original Object   {0}      {1}         {2}   {3}    {4}       {5} ", CPT2.Service, CPT2.Operator, CPT2.Circle, CPT2.Provider, CPT2.Comm.IncomingCommission, CPT2.Comm.OutgoingCommission);

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
