using System.Collections.Generic;
using CSharpAdvanced_Class4.Interfaces;

namespace CSharpAdvanced_Class4
{
    public class Module : Item, IPrice, IDiscont
    {
        private readonly List<Part> _parts = new List<Part>();

        public Module()
        {
        }

        public Module(string name)
        {
            Name = name;
        }

        public void SetDiscount(double discount)
        {
            // TODO: Implement the SetDiscount() method for the Modules
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             */
            //double getDiscount = discount/ 100 * discount;
            double _setDiscount = 0.0;
            if (discount < 0.0) _setDiscount = 0;
            else if (discount > 0.0 && discount <= 1.0) _setDiscount = discount;
            else if (discount > 1.0 && discount <= 100.00) _setDiscount = discount / 100;
            else _setDiscount = 1.0;

            Discount = _setDiscount;

        }

        public double GetPriceWithDiscount()
        {
            var price = GetPrice();
            var discount = Discount;
            return GetPrice() * (1 - Discount);
        }

        public double GetPrice()
        {
            // TODO: Implement the GetPrice() method for the Modules
            double price = 0;
            foreach (var pricePart in _parts)
            {
                price += pricePart.Price * pricePart.Quantity;

            }

            return price; // remove this after implementation
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }
    }
}