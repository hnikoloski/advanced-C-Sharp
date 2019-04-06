using System.Collections.Generic;
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{
    public class Configuration : Item, IPrice, IDiscont
    {
        private List<Module> _modules = new List<Module>();
        private List<Part> _parts = new List<Part>();

        public Configuration()
        {
        }

        public Configuration(Colors boxColor)
        {
            BoxColor = boxColor;
        }

        public Colors BoxColor { get; set; }
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }

        public void SetDiscount(double discount)
        {
            // TODO: Implement the SetDiscount() method for the Configurations
            /*
             * The percentage is a number in the range [0,100]. 5% == 0.05, 10% == 0.1
             * The method should set the Discount property to values between [0.00, 1.00]
             * Implementation can be the same as in Module class.
             */
            double _setDiscount = 0.0;
            if (discount < 0.0) _setDiscount = 0;
            else if (discount > 0.0 && discount <= 1.0) _setDiscount = discount;
            else if (discount < 1.0 && discount >= 100) _setDiscount = discount / 100;

        }

        public double GetPrice()
        {
            // TODO: Implement the GetPrice() method for the Configurations
            /* 
             * Consider the _parts and _modules lists. Two foreach loops are needed.
             */
            double price = 0.0;


            return price; // remove this after implementation            
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            // TODO: Implement the AddPartToProduct() method for the Configuration 
            //var productsToAdd = _parts;
        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            // TODO: Implement the AddModuleToProduct() method for the Configurations 
        }
    }
}