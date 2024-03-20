using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entity
{
    public class Bill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; }
        public int CartId { get; set; }
        public float Subtotal { get; set; }
        public float Total { get; set; }
        public float TotalIVA { get; set; }
        public DateTime DateTime { get; set; }
    }
}
