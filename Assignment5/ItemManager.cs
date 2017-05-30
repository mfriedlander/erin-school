using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class ItemManager
    {
        private List<ShoppingItem> itemList;

        public int Count
        {
            get
            {
                // Ensure that itemList isn't null
                if (itemList != null)
                {
                    // Return number of items in the list via itemList.Count
                    return itemList.Count;
                }
                
                // return that there are 0 items in the list
                return 0;
            }
        }

        public void AddItem(ShoppingItem itemIn)
        {
            // Add item to the list
            itemList.Add(itemIn);
        }

        public void ChangeItem(ShoppingItem itemIn, int index)
        {
            // Ensure that list has at least as many items as the
            // index specifies, add to the list at the specified 
            // location OR to the end of the list (if index is too far)
            // itemList[index] = itemIN
            if (itemList[index] != null)
            {
                itemList[index] = itemIn;
            }
        }

        public void DeleteItem (int index)
        {
            // Ensure list has an item at this index, remove if applicable
            if (itemList[index] != null)
            {
                itemList.RemoveAt(index);
            }
        }

        public ShoppingItem GetItem(int index)
        {
            // Return the item at the specified index (if applicable)
            if (itemList[index] != null)
            {
                return itemList[index];
            }
            else
            {
                return null;
            }
        }

        public string[] GetItemInfoStrings()
        {
            string[] values = new string[Count];
            int counter = 0;

            // Iterate over all items and return string version of each
            // in a string array
            foreach (ShoppingItem item in itemList)
            {
                values[counter] = item.ToString();
                counter++;
            }
            return values;
        }

        public ItemManager()
        {
            // Initialize list of shopping items
            itemList = new List<ShoppingItem>();
        }
    }
}
