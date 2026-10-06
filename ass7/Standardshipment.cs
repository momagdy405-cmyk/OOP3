using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6
{
    internal class Standardshipment : Shipman
    {
        Standardshipment(string trackingcode,string description,int weight,int delivery, Delivaryaddress destination) : base(trackingcode,description,weight,delivery,destination)
        {
        }
        public override void printshipman()
        {
            base.printshipman();
            Console.WriteLine(Estimate);
        }

    }
}