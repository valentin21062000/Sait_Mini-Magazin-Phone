using Humanizer.Localisation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examen.Models
{
	[Table("Phone")]
	public class Phone
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(40)]
		public string? PhoneName { get; set; }

		[Required]
		[MaxLength(40)]
		public string? Company { get; set; }
		[Required]
        public double Price { get; set; }
		public string? Image { get; set; }
		[Required]
		public int ModelId { get; set; }
		public Model Model { get; set; }
		public List<OrderDetail> OrderDetail { get; set; }
		public List<CartDetail> CartDetail { get; set; }

		[NotMapped]
		public string ModelName { get; set; }

	}
}