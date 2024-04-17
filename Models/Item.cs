using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace InventoryManegmentSystem3.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String IdItem { get; set; }
        public string ItName { get; set; }
        public String   CatId { get; set; }
        public int Qty { get; set; }
        public double SoldQty { get; set; }
        public double Cost { get; set; }
        public DateOnly ItDate { get; set; }
        public String manufacturer { get; set; }
        public String SalesPer { get; set; }
        public String Address { get; set; }
        public string Telephone { get; set; }
        public double ItSale { get; set; }
    }
}
