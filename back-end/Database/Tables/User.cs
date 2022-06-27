using System.ComponentModel.DataAnnotations;

namespace SkinServerNext.Database.Tables;
public class User {
	public int ID { get; set; }

	[StringLength(128)]
	public string Name { get; set; }

	[StringLength(128)]
	public string? DisplayName { get; set; }

	[StringLength(64)]
	public string PasswordSalt { get; set; }

	[StringLength(44)]
	public string PasswordHash { get; set; }

	[StringLength(128)]
	public string Email { get; set; }

	public ulong Experience { get; set; }

	public User(string name, string passwordSalt, string passwordHash, string email, ulong experience, string? displayName = null) {
		Name = name;
		PasswordSalt = passwordSalt;
		PasswordHash = passwordHash;
		Email = email;
		Experience = experience;
		DisplayName = displayName;
	}
}