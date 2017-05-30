using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model;

namespace RatingRequirements.Data.Mapping
{
    /// <summary>
    /// Маппинг сущности "Тип показателя" на БД.
    /// </summary>
    public class IndicatorTypeMapping : DommelEntityMap<IndicatorType>
    {
        public IndicatorTypeMapping()
        {
            ToTable("indicator_type");

            Map(e => e.IndicatorTypeId)
                .IsKey()
                .IsIdentity()
                .ToColumn("indicator_type_id");
            Map(e => e.Name)
                .ToColumn("name");
        }
    }
}
