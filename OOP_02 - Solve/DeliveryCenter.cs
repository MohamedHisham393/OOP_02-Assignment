using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_02___Solve
{
    internal class DeliveryCenter
    {
        private Shipment[] _shipments;
        private string _centerName;

        public string CenterName
        {
            get
            {
                return _centerName; 
            }
            set
            {
                _centerName = value;
            }
        }

        public DeliveryCenter(string centername)
        {
            _shipments = new Shipment[20];
            CenterName = centername; 
        }

        public Shipment this[int index]
        {
            get
            {
                if (_shipments is not null && index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }
                else return default;
            }

            set
            {
                if (_shipments is not null && index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null && trackingCode == _shipments[i].TrackingCode)
                    {
                        return _shipments[i];
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment ship)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = ship;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null && trackingCode == _shipments[i].TrackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("=========================================");
            Console.WriteLine();

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null)
                {
                    _shipments[i].PrintShipment();
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }

    }
}
