using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Inventory
    {
        private List<Item> items = new List<Item>();
        //생성자 
        public Inventory() {
            Console.WriteLine("인벤토리가 생성되었습니다.");
        }

        public void AddItem(Item item) {
            this.items.Add(item);
            Console.WriteLine(item.ToString() + "이 추가 되었습니다.");
        }
    }
}
