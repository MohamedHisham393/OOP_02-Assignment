using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP_02___Solve
{
    internal class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        private decimal _customsFee;

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destnation, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destnation)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get => _destinationCountry;
            set
            {
                if(!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        public decimal CustomsFee {
           
            get 
            {
                return _customsFee;
            } 

            set
            {
                if (value >= 0) 
                {
                    _customsFee = value;
                }
            } 
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }

        protected override void PrintExtraDetails()
        {
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee         : {CustomsFee} EGP");
        }
    }
}
