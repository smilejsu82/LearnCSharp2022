﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item(100, "장검");
            Console.WriteLine(item.ToString());

            Inventory inven = new Inventory();
            inven.AddItem(item);

            Item foundItem = inven.GetItemByName("장검");
            Console.WriteLine(foundItem.ToString() + "을 찾았습니다.");
        }
    }
}
