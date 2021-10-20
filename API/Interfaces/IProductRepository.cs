using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IProductRepository
    {
        void Update(Product product);


        Task<IQueryable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> CreateProductAsync(Product product);

        Task<Product> UpdateProductAsync(int id, Product product);

        Task<DeleteResponse> DeleteProductAsync(int id);

        Task<PageResponse> SearchProductAsync(string query, int? pageNumber, int? pageSize);

        Task<PageResponse> GetAllProductsAsync(int category, int? pageNumber, int? pageSize);

    }
}