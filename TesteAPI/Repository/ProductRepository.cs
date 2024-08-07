using Microsoft.AspNetCore.Http.HttpResults;
using TesteAPI.Domains;
using TesteAPI.Interface;

namespace TesteAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        public ProductContext _context = new ProductContext();

        

        public ProductRepository() 
        {
            _context = new ProductContext();
        }

        public void Delete(Guid id)
        {
            try
            {
                Product product = _context.Product.Find(id)!;

                if (product != null)
                {
                    _context.Product.Remove(product);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> Get()
        {
            try
            {
                return _context.Product.Select(x => new Product
                {
                    IdProduct = x.IdProduct,
                    Name = x.Name,
                    Price = x.Price
                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetById(Guid id)
        {
            try
            {
                return _context.Product.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Product product)
        {
            try
            {
                _context.Product.Add(product);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Put(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
