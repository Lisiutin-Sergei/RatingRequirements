using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model;

namespace RatingRequirements.Data.Mapping
{
	/// <summary>
	/// Маппинг сущности "Пользователь" на БД.
	/// </summary>
	public class UserMapping : DommelEntityMap<User>
	{
		public UserMapping()
		{
			ToTable("user");

			Map(e => e.UserId)
				.IsKey()
				.IsIdentity()
				.ToColumn("user_id");
			Map(e => e.Name)
				.ToColumn("name");
			Map(e => e.PasswordHash)
				.ToColumn("password_hash");
			Map(e => e.Login)
				.ToColumn("login");
		}
	}
}
