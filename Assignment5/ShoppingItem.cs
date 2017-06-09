using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Represents a shopping item.
    /// </summary>
    public class ShoppingItem
    {
        private double amount;
        private string description;
        private UnitTypes unit;

        /// <summary>
        /// Amount of this item.
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
            }
        }

        /// <summary>
        /// Description of this item.
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        /// <summary>
        /// The measurement unit type of this item.
        /// </summary>
        public UnitTypes Unit
        {
            get { return unit; }
            set
            {
                if (Enum.IsDefined (typeof (UnitTypes), value))
                {
                    unit = value;
                }
            }
        }

        /// <summary>
        /// Creates a new instance of ShoppingItem.
        /// </summary>
        public ShoppingItem() : this("N/A", 0.0, UnitTypes.cm)
        {
        }

        /// <summary>
        /// Creates a new instance of ShoppingItem.
        /// </summary>
        /// <param name="other">Another item to initialize this item with.</param>
        public ShoppingItem(ShoppingItem other) : this(other.Description, other.Amount, other.Unit)
        {
        }

        /// <summary>
        /// Creates a new instance of ShoppingItem.
        /// </summary>
        /// <param name="description">The description of the item.</param>
        public ShoppingItem(string description) : this(description, 0.0, UnitTypes.cm)
        {
        }

        /// <summary>
        /// Creates a new instance of ShoppingItem.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        /// <param name="amount">Amount of the item.</param>
        /// <param name="unit">Measurement unit of the amount of this item.</param>
        public ShoppingItem(string name, double amount, UnitTypes unit)
        {
            this.description = name;
            this.amount = amount;
            this.unit = unit;
        }
        
        /// <summary>
        /// Renders this item into a string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Empty;
            strOut = $"{description,-35} {amount,6:f2} {unit,-6}";
            return strOut;
        }
    }
}
