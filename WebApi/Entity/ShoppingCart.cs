using System.ComponentModel.DataAnnotations;

namespace WebApi.Entity
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }

        // Agregar propiedad para representar la relación con ShoppingCartArticle
        public virtual ICollection<ShoppingCartArticle> ShoppingCartArticles { get; set; }
    }
}
