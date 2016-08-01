using System.Collections.Generic;
using System.Linq;
using EssentialTools.Models.Interfaces;

namespace EssentialTools.Models
{
	public class LinqValueCalculator : IValueCalculator
	{
		private static int counter = 0;
		private IDiscountHelper discounter;

		public LinqValueCalculator(IDiscountHelper discountParam)
		{
			discounter = discountParam;
			System.Diagnostics.Debug.WriteLine(string.Format("Instance {0} created", ++counter));
		}

		public decimal ValueProducts(IEnumerable<Product> products)
		{
			return discounter.ApplyDiscount(products.Sum(p => p.Price));
		}
	}
}