using TesteAPI.Domains;

namespace TesteAPI.Interface
{
    public interface IProductRepository
    {
        public List<Product> Get();
        public Product GetById(int id);
        public void Post(Product product);
        public void Put(int id, Product product);
        public void Delete(int id);
    }
}
