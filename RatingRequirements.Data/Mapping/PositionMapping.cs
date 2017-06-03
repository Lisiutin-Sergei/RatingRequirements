using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model.Domain;

namespace RatingRequirements.Data.Mapping
{
    /// <summary>
    /// Маппинг сущности "Должность" на БД.
    /// </summary>
    public class PositionMapping : DommelEntityMap<Position>
    {
        public PositionMapping()
        {
            ToTable("position");

            Map(e => e.PositionId)
                .IsKey()
                .IsIdentity()
                .ToColumn("position_id");
            Map(e => e.Name)
                .ToColumn("name");
        }
    }
}
