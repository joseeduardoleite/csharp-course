using System;
using System.Globalization;

namespace Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufacture date: "
            + ManufactureDate.ToString("dd/MM/yyyy")
            + ")";
        }
    }
}