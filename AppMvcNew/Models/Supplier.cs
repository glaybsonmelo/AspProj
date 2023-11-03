namespace AppMvcNew.Models
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public SupplierType supplierType { get; set; }
        public Address address { get; set; }
        public bool Active { get; set; }
    }
}
