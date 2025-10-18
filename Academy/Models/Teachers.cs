using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Teachers
	{
		[Key]
		//[Column(TypeName = "int")]
		public short teacher_id { get; set; }

		[Required]
		public string last_name { get; set; } = string.Empty;
		[Required]
		public string first_name { get; set; } = string.Empty;
		public string? middle_name { get; set; } = string.Empty;
		[Required]
		public DateOnly? birth_date { get; set; }
		public string? email { get; set; } = string.Empty;
		public string? phone { get; set; } = string.Empty;
		public byte[]? photo { get; set; } // ? - так как это поле в базе может быть NULL
		[Required]
		public DateOnly? work_since { get; set; }
		[Required]
		public decimal rate { get; set; }
	}
}
