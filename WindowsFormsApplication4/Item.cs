using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication4
{
    public class Item
    {
        //static int priceIndex = 2;
        private int id;
        private int defindex;
        private string itemName;
        private string quality;
        private bool? craft;
      
        public int Id { get { return id; } set { id = value; } }
        public int Defindex { get { return defindex; } set { defindex = value; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public string Quality { get { return quality; } set { quality = value; } }
        public bool? Craft { get { return craft; } set { craft = value; } }


        public Item(int id, int defindex, string itemName, string quality, bool? craft)
        {
            this.id = id;
            this.defindex = defindex;
            this.itemName = itemName;
            this.quality = quality;
            this.craft = craft;
        }
    }
}
