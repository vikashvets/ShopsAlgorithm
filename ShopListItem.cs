namespace Shops
{
    class ShopListItem
    {
        public int itemDepartment { get; set; }
        public bool isBuyed { get; set; }

        public ShopListItem (int itemDepartment)
        {
            this.itemDepartment = itemDepartment;
            this.isBuyed = false;
        }
    }
}
