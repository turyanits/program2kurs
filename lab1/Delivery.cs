using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace Lab1
{
    public class Delivery
    {
        public int Id { get; set; }
        public int WarehouseNumber { get; set; }
        public string StoreName { get; set; }
        public int ProductCode { get; set; }
        public int Units { get; set; }
        public decimal PricePerUnit { get; set; }
    }
}