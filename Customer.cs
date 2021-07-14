using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shops
{
    class Customer
    {
        public List<ShopListItem> shopList { get; set; }
        public bool isServing { get; set; }
        bool isWaiting;
        public int spendedTime { get; set; }
        public int waitingTime { get; set; }
        public Customer(List<ShopListItem> shopList)
        {
            this.shopList = shopList;
            this.isWaiting = false;
            this.isServing = false;
            this.waitingTime = 0;
            this.spendedTime = 0;
        }

        public bool CheckForServeAvailibility(Department department)
        {
            return true;
        }

        public bool isServed()
        {
            return this.shopList.Any(item => item.isBuyed);
        }

        public void HandleServing(Department department)
        {

        }

    }
}
