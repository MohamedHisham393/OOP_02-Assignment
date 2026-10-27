using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02___Solve
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destnation) :base(trackingCode, description, weight, deliveryFee, destnation)
        {

        }
    }
}
