using TesteAPI.Domains;

namespace TesteAPI.Interface
{
    public interface IProductRepository
    {
        public List<Product> Get();
        public Product GetById(Guid id);
        public void Post(Product product);
        public void Put(Guid id, Product product);
        public void Delete(Guid id);
    }
}
