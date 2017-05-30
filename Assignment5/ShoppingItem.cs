using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class ShoppingItem
    {
        private double amount;
        private string description;
        private UnitTypes unit;

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

        public ShoppingItem() : this("N/A", 0.0, UnitTypes.cm)
        {
        }

        public ShoppingItem(ShoppingItem other) : this(other.Description, other.Amount, other.Unit)
        {
        }

        public ShoppingItem(string description) : this(description, 0.0, UnitTypes.cm)
        {
        }

        public ShoppingItem(string name, double amount, UnitTypes unit)
        {
            this.description = name;
            this.amount = amount;
            this.unit = unit;
        }

        public override string ToString()
        {
            // TODO: fill this out based on output need
            string strOut = string.Empty;
            strOut = $"{description,-45} {amount,6:f2} {unit,-6}";
            return strOut;
        }
    }
}
