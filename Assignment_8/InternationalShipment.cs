using Assignment_8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8
{
    public class InternationalShipment : Shipment
    {
        private string _destinationCountry;
        private decimal _customsFee;

        public string DestinationCountry
        {
            get
            {
                return _destinationCountry;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
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
            get
            {
                return DeliveryFee
                    + ((decimal)Weight * 5)
                    + CustomsFee;
            }
        }

        public InternationalShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("-----");
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

    }
}
