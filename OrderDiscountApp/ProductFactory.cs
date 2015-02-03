// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductFactory.cs" company="Oleg Abrashchov">
//   Copyright (c) Oleg Abrashchov 2015
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace OrderDiscountApp
{
    using System;

    /// <summary>
    /// The product factory.
    /// </summary>
    public static class ProductFactory
    {
        #region Public Methods and Operators

        /// <summary>
        /// The parse product.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        /// <returns>
        /// The <see cref="Product"/>.
        /// </returns>
        public static Product ParseProduct(string input)
        {
            GoodType goodType;
            if (Enum.TryParse(input, true, out goodType))
            {
                switch (goodType)
                {
                    case GoodType.A:
                        return new ProductA();
                    case GoodType.B:
                        return new ProductB();
                    case GoodType.C:
                        return new ProductC();
                    default:
                        return null;
                }
            }

            return null;
        }

        #endregion
    }
}