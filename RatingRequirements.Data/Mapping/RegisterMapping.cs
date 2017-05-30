using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model;

namespace RatingRequirements.Data.Mapping
{
    /// <summary>
    /// Маппинг сущности "Реестр" на БД.
    /// </summary>
    public class RegisterMapping : DommelEntityMap<Register>
    {
        public RegisterMapping()
        {
            ToTable("register");

            Map(e => e.RegisterId)
                .IsKey()
                .IsIdentity()
                .ToColumn("register_id");
            Map(e => e.Name)
                .ToColumn("name");
            Map(e => e.RegisterDate)
                .ToColumn("register_date");
            Map(e => e.UserId)
                .ToColumn("user_id");
        }
    }
}
