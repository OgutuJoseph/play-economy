using System;

namespace Play.Catalog.Service.Entities
{
    // public interface IItem
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}