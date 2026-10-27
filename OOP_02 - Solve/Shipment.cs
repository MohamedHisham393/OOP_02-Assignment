using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02___Solve
{
    internal class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destnation)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destnation;
        }


        public string TrackingCode
        {
            get { return _trackingCode; }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }

        }

        public string Description
        {
            get => _description;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get => _deliveryFee;
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public virtual decimal EstimatedCost
        {
            get { return _deliveryFee + (_weight * 5); }
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.WriteLine($"Tracking Code : {_trackingCode}");
            Console.WriteLine($"Description : {_description}");
            Console.WriteLine($"Weight : {_weight}");
            Console.WriteLine($"Delivery fee : {_deliveryFee} ");
            Console.WriteLine($"Destination : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        }


        protected virtual void PrintExtraDetails()
        {

        }
    }
}
