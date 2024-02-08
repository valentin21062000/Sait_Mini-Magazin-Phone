using Examen.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Models
{
	[Table("OrderDetail")]
	public class OrderDetail
	{
		public int Id { get; set; }
		[Required]
		public int OrderId { get; set; }
		[Required]
		public int PhoneId { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public double UnitPrice { get; set; }
		public Order Order { get; set; }
		public Phone Phone { get; set; }
	}
}