using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Stores
{
    /// <summary> Base class for product database </summary>
    public abstract class ProductDatabase : IProductDatabase
    {
        /// <summary>Adds a product.</summary>          
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        /// <exception cref="ArgumentNullException">Product is null</exception>
        /// <exception cref="ValidationException">Product is invalid</exception>
        public Product Add(Product product)
        {
            //Validate
            if (product == null)
                throw new ArgumentNullException(nameof(product), "Product was null");
            
            //System.ComponentModel.DataAnnotations.Validator.
            //if (!ObjectValidator.TryValidate(product, out var errors))
            //    throw new System.ComponentModel.DataAnnotations.ValidationException("Product was not valid", nameof(product));
            //return null;
            ObjectValidator.Validate(product);

            try
            {
                return AddCore(product);
            } catch (Exception e)
            {
                //Throw different exception
                throw new Exception("Add failed", e);

                //Re-throws the previous error
                throw;  

                //Silently ignore  - almost always bad
            };
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get(int id)
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");
                //return null;

            return GetCore(id);
        }

        protected abstract Product GetCore(int id);
        

        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll()
        {
            return GetAllCore();
            
            #region Ignore
            //How many products?
            //var count = 0;
            //foreach (var product in _products)
            //{
            //    if (product != null)
            //        ++count;
            //};

            //var items = new Product[count];
            //var index = 0;

            //foreach (var product in _products)
            //{
            //    if (product != null)
            //        //product = new Product();
            //        items[index++] = CopyProduct(product);
            //};

            //return items;
#endregion
        }

        protected abstract IEnumerable<Product> GetAllCore();

        /// <summary>Removes the product.</summary>
        /// <param name="product">The product to remove.</param>
        public void Remove(int id)
        {
            //TODO: Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");
            //return;

            RemoveCore(id);

            //if (_list[index].Name == product.Name)
            //{
            //    _list.RemoveAt(index);
            //    break;
            //};        
        }

        protected abstract void RemoveCore(int id);

        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update(Product product)
        {
            //Validate
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            //if (!ObjectValidator.TryValidate(product, out var errors))
            //    throw new ArgumentException("Product is invalid", nameof(product));
            ObjectValidator.Validate(product);

            //Use throw exception
            //Get existing product
            var existing = GetCore(product.Id) ?? throw new Exception("Product not found");
            //if (existing == null)
            //    throw new Exception("Product not found");

            return UpdateCore(existing, product);
        }

        protected abstract Product UpdateCore(Product existing, Product newItem);

        protected abstract Product AddCore(Product product);
    }
}
