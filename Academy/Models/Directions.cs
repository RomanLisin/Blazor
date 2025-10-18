using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Directions
	{
		[Key]
		//[Column(TypeName = "int")]
		public byte direction_id { get; set; }
		[Required]
		public string direction_name { get; set; } = string.Empty;

	}
}
