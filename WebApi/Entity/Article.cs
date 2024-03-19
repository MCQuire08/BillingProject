using System.ComponentModel.DataAnnotations;

namespace WebApi.Entity
{
    public class Article
    {
        [Key]
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double IVA { get; set; }
    }
}
