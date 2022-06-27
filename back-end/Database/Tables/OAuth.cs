using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkinServerNext.Database.Tables;
public class OAuthAccount {
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int UserID { get; set; }
	public string? MicrosoftID { get; set; }
	public string? MicrosoftName { get; set; }
	public string? MicrosoftDisplayName { get; set; }

	public OAuthAccount(int userID, string? microsoftID = null, string? microsoftName = null, string? microsoftDisplayName = null) {
		UserID = userID;
		MicrosoftID = microsoftID;
		MicrosoftName = microsoftName;
		MicrosoftDisplayName = microsoftDisplayName;
	}
}