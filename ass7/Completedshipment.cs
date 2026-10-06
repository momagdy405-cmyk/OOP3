using ass6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass7
{
    internal sealed class Completedshipment:Shipman
    {
        Completedshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination) : base(trackingcode, description, weight, delivery, destination)
        {

        }
    }
}
