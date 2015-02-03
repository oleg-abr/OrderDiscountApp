// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscountOne.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// The discount three.
    /// </summary>
    public class DiscountNone : IDiscount
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
        [SuppressMessage("StyleCop.CSharp.LayoutRules", "SA1503:CurlyBracketsMustNotBeOmitted", Justification = "Reviewed. Suppression is OK here.")][SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1627:DocumentationTextMustNotBeEmpty", Justification = "Reviewed. Suppression is OK here.")]
        public double GetDiscountedPrice(List<Product> products)
        {
            if (products == null)
                throw new ArgumentNullException("products cannot be null");

            var originalPrice = products.Sum(p => p.Price);

            return originalPrice;
        }

        #endregion
    }
}