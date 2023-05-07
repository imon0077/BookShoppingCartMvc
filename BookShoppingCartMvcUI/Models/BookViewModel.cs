namespace BookShoppingCartMvcUI.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string? BookName { get; set; }

        public string? AuthorName { get; set; }

        public double Price { get; set; }  
        public IFormFile? ImageUrl { get; set; }

        public int GenreId { get; set; }
    }
}
