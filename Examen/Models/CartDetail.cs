using Examen.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Models
{
	[Table("CartDetail")]
	public class CartDetail
	{
		public int Id { get; set; }
		[Required]
		public int ShoppingCartId { get; set; }
		[Required]
		public int PhoneId { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public double UnitPrice { get; set; }
		public Phone Phone { get; set; }
		public ShoppingCart ShoppingCart { get; set; }
	}
}