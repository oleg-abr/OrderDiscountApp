// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscountAll.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System.Collections.Generic;

    /// <summary>
    /// The discount all.
    /// </summary>
    public class DiscountAll : Decorator
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountAll"/> class.
        /// </summary>
        /// <param name="discount">
        /// The discount.
        /// </param>
        public DiscountAll(IDiscount discount)
            : base(discount)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The get discounted price.
        /// </summary>
        /// <param name="products">
        /// The products.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public new double GetDiscountedPrice(List<Product> products)
        {
            return discount.GetDiscountedPrice(products) * 0.95;
        }

        #endregion
    }
}