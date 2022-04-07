using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIDemo.Models
{
    public class Order
    {
        public string Id { get; set; }
        public int Quantity { get; set; }
        public List<string> ProductRefId { get; set; }
        public string CustomerRefId { get; set; }
        public string StaffRefId {get; set; }
    }
}