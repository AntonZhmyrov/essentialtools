using System.Collections.Generic;
using System.Linq;
using EssentialTools.Models.Interfaces;

namespace EssentialTools.Models
{
	public class LinqValueCalculator : IValueCalculator
	{
		public decimal ValueProducts(IEnumerable<Product> products)
		{
			return products.Sum(p => p.Price);
		}
	}
}