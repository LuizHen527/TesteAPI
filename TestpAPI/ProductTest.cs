using Moq;
using TesteAPI.Domains;
using TesteAPI.Interface;
using TesteAPI.Repository;

namespace TestpAPI
{
    public class ProductTest
    {
        //indica um metodo de teste de unidade
        [Fact]
        public void TestGet()
        {
            //Arange : organizar, cenario
            var product = new List<Product>
            {
                new Product {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 10 },
                new Product {IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 15 },
                new Product {IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 3 },
            };

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Get()).Returns(product);

            //Act : Acao

            //Chama o metodo Get
            var result = mockRepository.Object.Get();

            //Assert : provar

            //Prova se o resultado esperado e igual ao resultado obtido atraves da busca
            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void TestPost()
        {
            var product = new Product { IdProduct = Guid.NewGuid(), Name = "Leite", Price = 10 };

            var productsList = new List<Product>();

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Post(product)).Callback<Product>(x => productsList.Add(product));

            mockRepository.Object.Post(product);

            Assert.Contains(product, productsList);
        }

        //GetById

        [Fact]
        public void GetById()
        {

        }

        //Delete

        //Update
    }
}