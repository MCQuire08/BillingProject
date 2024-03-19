namespace WebApi.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }

        // Corregir el tipo devuelto aquí
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
