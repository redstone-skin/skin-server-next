using System.ComponentModel.DataAnnotations;

namespace SkinServerNext.Database.Tables;
public class User {
	public long Id { get; set; }

	[Required]
	public string? Name { get; set; }

	[Required]
	public string? DisplayName { get; set; }

	[Required]
	public string? PasswordSalt { get; set; }

	[Required]
	public string? PasswordHash { get; set; }

	[Required]
	public string? Email { get; set; }

	[Required]
	public int Level { get; set; }
	
	public string? MicrosoftID { get; set; }
	public string? MicrosoftName { get; set; }
	public string? MicrosoftDisplayName { get; set; }
}