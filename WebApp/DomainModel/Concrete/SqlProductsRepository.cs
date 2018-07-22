using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Abstract;
using DomainModel.Entities;
using System.Data.Linq;
using System.ComponentModel;

namespace DomainModel.Concrete
{
    public class SqlProductsRepository : IProductsRepository
    {
        private Table<Product> productsTable;
        public SqlProductsRepository(string connectionString)
        {
            productsTable = (new DataContext(connectionString)).GetTable<Product>();
        }
        public IQueryable<Product> Products
        {
            get { return productsTable; }
        }

        public void SaveProduct(Product product) {

            EnsureValid(product, "Name", "Description", "Category", "Price");

            if (product.ProductID == 0) {
                product.CreateDate = DateTime.Now;
                productsTable.InsertOnSubmit(product);
            }
            else {
                // If we're updating an existing product, tell the DataContext
                // to be responsible for saving this instance
                productsTable.Attach(product);
                // Also tell the DataContext to detect any changes since the last save
                productsTable.Context.Refresh(RefreshMode.KeepCurrentValues, product);
            }
            productsTable.Context.SubmitChanges();
        }
        public void DeleteProduct(Product product) {
            productsTable.DeleteOnSubmit(product);
            productsTable.Context.SubmitChanges();
        }

        private void EnsureValid(IDataErrorInfo validatable, params string[] properties) {
            if (properties.Any(x => validatable[x] != null))
                throw new InvalidOperationException("The object is invalid.");
        }
    }   
}
