// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cart.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>The cart.</summary>
    [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "Reviewed. Suppression is OK here.")]    
    public class Cart
    {
        #region Constants and Fields

        /// <summary>The products list.</summary>
        private readonly List<Product> products;

        #endregion

        #region Constructors and Destructors

        /// <summary>Initializes a new instance of the <see cref="Cart"/> class.</summary>
        public Cart()
        {
            products = new List<Product>();
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>Adding product.</summary>
        /// <param name="product">The product.</param>
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        /// <summary>Gets the total price of products in the cart.</summary>
        /// <returns>The <see cref="double"/>.</returns>
        public double GetTotalPrice()
        {
            double totalPrice;
            var productsA = products.OfType<ProductA>().ToList();
            var productsB = products.OfType<ProductB>().ToList();
            var productsC = products.OfType<ProductC>().ToList();

            if (productsA.Count > 0 && productsB.Count > 0 && productsC.Count > 0)
            {
                totalPrice = new DiscountAll(new DiscountOne()).GetDiscountedPrice(productsA.Cast<Product>().ToList());
                totalPrice += new DiscountAll(new DiscountTwo()).GetDiscountedPrice(productsB.Cast<Product>().ToList());
                totalPrice += new DiscountAll(new DiscountNone()).GetDiscountedPrice(productsC.Cast<Product>().ToList());
            }
            else
            {
                totalPrice = new DiscountOne().GetDiscountedPrice(productsA.Cast<Product>().ToList());
                totalPrice += new DiscountTwo().GetDiscountedPrice(productsB.Cast<Product>().ToList());
                totalPrice += new DiscountNone().GetDiscountedPrice(productsC.Cast<Product>().ToList());
            }

            return totalPrice;
        }

        #endregion
    }
}