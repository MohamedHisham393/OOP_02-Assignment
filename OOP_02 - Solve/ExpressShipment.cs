using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02___Solve
{
    internal class ExpressShipment : Shipment
    {
        private decimal _extraFee;

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destnation, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destnation)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee 
        {
            get { return _extraFee; }

            set
            { 
                if(value >= 0)
                    _extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }

        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Extra Fee      : {ExtraFee} EGP");
        }
    }
}
