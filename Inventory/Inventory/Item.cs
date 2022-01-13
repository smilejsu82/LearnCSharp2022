using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Item
    {
        private int id;
        private string name;
        public Item(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.id, this.name);
        }
    }
}
