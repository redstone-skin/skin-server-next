using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkinServerNext.Database.Tables;
public class OAuthAccount {
	public int Id { get; set; }
	public int UserId { get; set; }
	public string? MicrosoftId { get; set; }
	public string? MicrosoftName { get; set; }
	public string? MicrosoftDisplayName { get; set; }

	public OAuthAccount(int userId, string? microsoftId = null, string? microsoftName = null, string? microsoftDisplayName = null) {
		UserId = userId;
		MicrosoftId = microsoftId;
		MicrosoftName = microsoftName;
		MicrosoftDisplayName = microsoftDisplayName;
	}
}