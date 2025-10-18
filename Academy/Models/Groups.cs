using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Groups
	{
		[Key]
		[Column(TypeName = "int")]
		public short group_id {get;set;}
		[Required]
		public string group_name { get; set; } = string.Empty;
		[Required]
		public byte direction { get; set;}

	}
}
