

namespace OrderDiscountApp
{
    using System;

    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        static void Main()
        {
            Cart cart = new Cart();
            int notvalidchar = 0;

            Console.WriteLine("Please enter the goods ");
            string inputs = Console.ReadLine();
            Console.WriteLine();

            foreach (char c in inputs.ToUpperInvariant())
            {
                Product product = ProductFactory.ParseProduct(c.ToString());
                if (product != null)
                {
                    cart.AddProduct(product);
                }
                else
                {
                    notvalidchar++;
                }
            }

            Console.WriteLine(" Total price : " + cart.GetTotalPrice() + " $");
            Console.WriteLine(" Not counted goods: " + notvalidchar + " item ");
            Console.ReadLine();
        }
    }
}
