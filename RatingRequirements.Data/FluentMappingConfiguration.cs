using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using RatingRequirements.Data.Mapping;

namespace RatingRequirements.Data
{
    /// <summary>
    /// Конфигурация Fluent Mapping для всех сущностей проекта.
    /// </summary>
    public static class FluentMappingConfiguration
    {
        public static void ConfigureMapping()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UserMapping());
                config.AddMap(new IndicatorMapping());
                config.AddMap(new IndicatorTypeMapping());
                config.AddMap(new RegisterMapping());
                config.AddMap(new DocumentMapping());
                config.AddMap(new PositionMapping());

                config.ForDommel();
            });
        }
    }
}
