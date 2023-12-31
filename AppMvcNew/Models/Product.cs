﻿namespace AppMvcNew.Models
{
    public class Product
    {
        public Guid SupplierId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime SignUpDate { get; set; }
        public bool Active { get; set; }

        public Supplier Supplier { get; set; }

    }
}
