using Shopping.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Entites
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
        public int Status { get; set; }
        public string? ProductDetail { get; set; }

    }
}
