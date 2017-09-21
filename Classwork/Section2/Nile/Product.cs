using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile
{
    /// <summary>Represents a product </summary>
    /// <remarks>
    /// This will represent a product with other stuff.
    /// </remarks>
    public class Product
    {
        private string _name;
        private string _description;

        private readonly double _someValueICannotChange = 10;

        public readonly Product None = new Product();
        
        /// <summary> Set the name. </summary>
        /// <value> Never Return NULL </value>
        public string Name
        {
            // string get_Name()
            get { return _name ?? ""; }
            // void set_Name (string value)
            set { _name = value?.Trim(); }

        }

        /// <summary> Set the discription. </summary>
        /// <value> Never Return NULL </value>
        public string Discription
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }

        /// <summary> Set the price. </summary>
        public decimal Price { get; set; }

        /// <summary> Determines if Discontinued. </summary>
        public bool IsDiscontinued { get; set; }

        public const decimal DiscontinuedDiscountRate = 0.10M;
        
        /// <summary> Get the discounted price, If applicable. </summary>
        /// <returns> The price </returns>
        public decimal GetDiscountedPrice
        {
            get
            {
                //if (IsDiscontinued)
                if (this.IsDiscontinued)
                    return Price * DiscontinuedDiscountRate;

                return Price;
            }
        }

        public int ICanOnlySet { get; private set; }
        public int ICanOnlySet2 { get; }

        public void Foo(string name)
        {
        }
    }
}
