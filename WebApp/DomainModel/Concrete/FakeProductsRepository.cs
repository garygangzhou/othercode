using DomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Entities;

namespace DomainModel.Concrete
{
    public class FakeProductsRepository : IProductsRepository
    {
        // Fake hard-coded list of products
        private static IQueryable<Product> fakeProducts = new List<Product> {
                    new Product { Name = "Football", Price = 25 },
                    new Product { Name = "Surf board", Price = 179 },
                    new Product { Name = "Running shoes", Price = 95 }
             }.AsQueryable();

        IQueryable<Product> IProductsRepository.Products
        {
            get
            {
                return fakeProducts;
            }
        }

        public void DeleteProduct(Product product) {
           
        }

        public void SaveProduct(Product product) {
            
        }
    }
}
