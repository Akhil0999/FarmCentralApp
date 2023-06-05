namespace FarmCentralApp.Models
{
    //1.Creating a Table in Database for Products
    public class ProductsEntity : FarmerEntity
    {
        public string Id { get; set; }
        public string farmerName { get; set; }
        public string productName { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }

        public DateOnly dateRange { get; set; }
        public string productType { get; set; }

        public string Source { get; set; }

    }
}
