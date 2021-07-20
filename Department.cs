namespace Shops
{
    class Department
    {
        public Departments department { get; set; }
        int customersCapacity;
        public int AvailableSlotsCount { get; set; }
        public int SecondsPerCustomer { get; set; }
        public int SecondsForAdditionalPurchase { get; set; }
        public Department(Departments department, int customersCapasity, int secondsPerCustomer, int secondsForAdditionalPurchase)
        {
            this.department = department;
            this.customersCapacity = customersCapasity;
            this.AvailableSlotsCount = customersCapasity;
            this.SecondsPerCustomer = secondsPerCustomer;
            this.SecondsForAdditionalPurchase = secondsForAdditionalPurchase;
        }

        public bool IsBusy()
        {
            return AvailableSlotsCount > 0;
        }

    }
}
