namespace Shops
{
    class Department
    {
        public Departments department { get; set; }
        int customersCapacity;
        public int availibleSlotsCount { get; set; }
        public int secondsPerCustomer { get; set; }
        public int secondsForAdditionalPurchase { get; set; }
        public Department(Departments department, int customersCapasity, int secondsPerCustomer, int secondsForAdditionalPurchase)
        {
            this.department = department;
            this.customersCapacity = customersCapasity;
            this.availibleSlotsCount = customersCapasity;
            this.secondsPerCustomer = secondsPerCustomer;
            this.secondsForAdditionalPurchase = secondsForAdditionalPurchase;
        }

        public bool IsBusy()
        {
            return availibleSlotsCount > 0;
        }

    }
}
