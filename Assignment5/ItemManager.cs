using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Represents an item manager of shopping items. 
    /// </summary>
    public class ItemManager
    {
        /// <summary>
        /// Internal representation of the list.
        /// </summary>
        private List<ShoppingItem> itemList;

        /// <summary>
        /// The number of items currently being managed.
        /// </summary>
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

        /// <summary>
        /// Adds an item to the manager.
        /// </summary>
        /// <param name="itemIn">The item to add.</param>
        public void AddItem(ShoppingItem itemIn)
        {
            // Add item to the list
            itemList.Add(itemIn);
        }

        /// <summary>
        /// Replaces the item at the specified index with the passed in item.
        /// </summary>
        /// <param name="itemIn">Replacement item.</param>
        /// <param name="index">Target index.</param>
        public void ChangeItem(ShoppingItem itemIn, int index)
        {
            // Ensure that list has at least as many items as the
            // index specifies, add to the list at the specified 
            // location OR to the end of the list (if index is too far)
            // itemList[index] = itemIn
            if (itemList[index] != null)
            {
                itemList[index] = itemIn;
            }
        }

        /// <summary>
        /// Deletes the item at the specified index.
        /// </summary>
        /// <param name="index">Target index.</param>
        public void DeleteItem (int index)
        {
            // Ensure list has an item at this index, remove if applicable
            if (itemList[index] != null)
            {
                itemList.RemoveAt(index);
            }
        }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        /// <param name="index">Target index.</param>
        /// <returns>Item at specified index or null if no items exists.</returns>
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

        /// <summary>
        /// Returns a list of strings representing the managed items.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Creates a new instance of the ItemManager.
        /// </summary>
        public ItemManager()
        {
            // Initialize list of shopping items
            itemList = new List<ShoppingItem>();
        }
    }
}
