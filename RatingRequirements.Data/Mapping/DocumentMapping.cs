using Dapper.FluentMap.Dommel.Mapping;
using RatingRequirements.Core.Model;

namespace RatingRequirements.Data.Mapping
{
    /// <summary>
    /// Маппинг сущности "Документ реестра" на БД.
    /// </summary>
    public class DocumentMapping : DommelEntityMap<Document>
    {
        public DocumentMapping()
        {
            ToTable("document");

            Map(e => e.DocumentId)
                .IsKey()
                .IsIdentity()
                .ToColumn("document_id");
            Map(e => e.IndicatorId)
                .ToColumn("indicator_id");
            Map(e => e.Name)
                .ToColumn("name");
            Map(e => e.FileName)
                .ToColumn("file_name");
            Map(e => e.Formula)
                .ToColumn("formula");
            Map(e => e.Points)
                .ToColumn("points");
            Map(e => e.RegisterId)
                .ToColumn("register_id");
        }
    }
}
