// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDiscount.cs" company="Oleg Abrashchov">
//   Oleg Abrashchov 
// </copyright>
// <summary>
//   The Discount interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OrderDiscountApp
{
    using System.Collections.Generic;

    /// <summary>
    /// The Discount interface.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Gets discounted price.
        /// </summary>
        /// <param name="products">
        /// The products.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        double GetDiscountedPrice(List<Product> products);
    }
}
