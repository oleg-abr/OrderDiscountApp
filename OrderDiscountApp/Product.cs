// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    /// <summary>
    /// The product.
    /// </summary>
    public abstract class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="price">
        /// The price.
        /// </param>
        protected Product(int price)
        {
            Price = price;
        }

        /// <summary>
        /// Gets the product's price.
        /// </summary>
        public int Price { get; private set; }
    }
}