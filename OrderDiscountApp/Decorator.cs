// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Decorator.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The decorator.
    /// </summary>
    public abstract class Decorator : IDiscount
    {
        #region Constants and Fields

        /// <summary>
        /// The discount.
        /// </summary>
        protected IDiscount discount;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Decorator"/> class.
        /// </summary>
        /// <param name="discount">
        /// The discount.
        /// </param>
        protected Decorator(IDiscount discount)
        {
            this.discount = discount;
        }

        #endregion

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
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1101:PrefixLocalCallsWithThis", Justification = "Reviewed. Suppression is OK here.")]
        public double GetDiscountedPrice(List<Product> products)
        {
            return discount == null ? 0 : discount.GetDiscountedPrice(products);
        }

        #endregion
    }
}