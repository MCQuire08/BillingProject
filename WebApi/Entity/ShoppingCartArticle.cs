using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entity
{
    public class ShoppingCartArticle
    {
        [Key]
        public int IdShoppingCartArticle { get; set; }
        public int CartId { get; set; }
        public string ArticleId { get; set; }
        public int Amount { get; set; }
    }

}
