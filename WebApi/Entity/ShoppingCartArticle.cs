namespace WebApi.Entity
{
    public class ShoppingCartArticle
    {
        public int CartId { get; set; }
        public int ArticleId { get; set; }
        public int Amount { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual Article Article { get; set; }
    }
}
