using System.Collections.Generic;
using System.Linq;

namespace Shops
{
    class Customer
    {
        public List<ShopListItem> ShopList { get; set; }
        public bool IsServing { get; set; }
        bool IsWaiting;
        public int SpendedTime { get; set; }
        public int WaitingTime { get; set; }
        public Customer(List<ShopListItem> shopList)
        {
            this.ShopList = shopList;
            this.IsWaiting = false;
            this.IsServing = false;
            this.WaitingTime = 0;
            this.SpendedTime = 0;
        }

        public bool CheckForServeAvailability(Department department)
        {
            return true;
        }

        public bool IsServed()
        {
            return ShopList.All(item => item.isBuyed);
        }

        public void HandleServing(Department department)
        {

        }

    }
}
