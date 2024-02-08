using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Examen.Models;

namespace Examen.Models
{
	[Table("Model")]
	public class Model
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(40)]
		public string ModelName { get; set; }
		public List<Phone> Phones { get; set; }
	}
}