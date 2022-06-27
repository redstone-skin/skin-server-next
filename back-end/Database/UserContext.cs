using Microsoft.EntityFrameworkCore;

namespace SkinServerNext.Database;
public class UserContext: DbContext {
	public UserContext(DbContextOptions<UserContext> options) : base(options) {}
	public DbSet<Tables.OAuthAccount> OAuthAccounts { get; set; }
	public DbSet<Tables.User> Users { get; set; }
}