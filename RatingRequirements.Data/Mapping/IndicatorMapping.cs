using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model;

namespace RatingRequirements.Data.Mapping
{
    /// <summary>
    /// Маппинг сущности "Показатель" на БД.
    /// </summary>
    public class IndicatorMapping : DommelEntityMap<Indicator>
    {
        public IndicatorMapping()
        {
            ToTable("indicator");

            Map(e => e.IndicatorId)
                .IsKey()
                .IsIdentity()
                .ToColumn("indicator_id");
            Map(e => e.Name)
                .ToColumn("name");
            Map(e => e.IndicatorTypeId)
                .ToColumn("indicator_type_id");
            Map(e => e.FormulaBase)
                .ToColumn("formula_base");
            Map(e => e.ParamsCount)
                .ToColumn("params_count");
			Map(e => e.LongName)
				.ToColumn("long_name");
			Map(e => e.OrderNumber)
				.ToColumn("order_number");
		}
    }
}
