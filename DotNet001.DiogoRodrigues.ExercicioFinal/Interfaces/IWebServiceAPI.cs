using DotNet001.DiogoRodrigues.ExercicioFinal.Models;
using Refit;

namespace DotNet001.DiogoRodrigues.ExercicioFinal.Interfaces
{
    public interface IWebServiceAPI
    {
        [Get("/products")]
        Task<List<Product>> GetAllProducts();

        [Get("/products/category/{category}")]
        Task<List<Product>> GetProductsByCategory(string category);

        [Get("/products/{id}")]
        Task<Product> GetProductById(int id);

        [Post("/products")]
        Task<Product> AddProduct([Body] Product product);

        [Put("/products/{id}")]
        Task<Product> UpdateProduct(int id, [Body] ProductUpdate productUpdate);

        [Delete("/products/{id}")]
        Task DeleteProduct(int id);
    }
}
