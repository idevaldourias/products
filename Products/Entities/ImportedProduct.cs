using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString("F2") + " (Customs free: $" + CustomsFree.ToString("F2") + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }
    }
}
