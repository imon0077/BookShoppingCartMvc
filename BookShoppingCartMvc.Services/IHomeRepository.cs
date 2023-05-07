using BookShoppingCartMvc.Models;

namespace BookShoppingCartMvc.Services
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Book>> GetBooks(string sTerm = "", int genreId = 0);

        Task<IEnumerable<Genre>> Genres();
    }

}