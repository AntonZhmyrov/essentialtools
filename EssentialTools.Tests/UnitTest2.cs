using System.Linq;
using EssentialTools.Models;
using EssentialTools.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EssentialTools.Tests
{
	/// <summary>
	/// Summary description for UnitTest2
	/// </summary>
	[TestClass]
	public class UnitTest2
	{
		private Product[] products =
	    {
			new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
			new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
			new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
			new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
	    };

		[TestMethod]
		public void Sum_Products_Correctly()
		{
			var mock = new Mock<IDiscountHelper>();
			mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
			var target = new LinqValueCalculator(mock.Object);

			var result = target.ValueProducts(products);

			Assert.AreEqual(products.Sum(e => e.Price), result);
		}

		private Product[] CreateProduct(decimal value)
		{
			return new[] {new Product {Price = value}};
		}
	}
}
