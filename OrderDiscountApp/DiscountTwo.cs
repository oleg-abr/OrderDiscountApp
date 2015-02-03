// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscountOne.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The discount two.
    /// </summary>
    public class DiscountTwo : IDiscount
    {
        #region IDiscount Members

        /// <summary>
        /// The get discounted price.
        /// </summary>
        /// <param name="products">
        /// The products.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public double GetDiscountedPrice(List<Product> products)
        {
            if (products == null)
                throw new ArgumentNullException("products cannot be null");

            int originalPrice = products.Sum(p => p.Price);

            if (products.Count < 6)
                return originalPrice;

            return originalPrice * 0.8;
        }

        #endregion
    }
}