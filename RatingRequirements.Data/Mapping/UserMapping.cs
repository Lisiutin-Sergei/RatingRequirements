﻿using Dapper.FluentMap.Dommel.Mapping;
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
            ToTable("user_");

            Map(e => e.UserId)
                .IsKey()
                .IsIdentity()
                .ToColumn("user_id");
            Map(e => e.Name)
                .ToColumn("name");
            Map(e => e.PasswordHash)
                .ToColumn("password");
            Map(e => e.Login)
                .ToColumn("login");
            Map(e => e.PositionId)
                .ToColumn("position_id");
        }
    }
}
