using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Academy.Models
{
	public class Students
	{
		[Key]
		[Column(TypeName = "int")]
		public short stud_id { get; set; }

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

		public int? group { get; set; }


	}
}
