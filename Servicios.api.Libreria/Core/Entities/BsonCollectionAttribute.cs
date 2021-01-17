using System;

namespace Servicios.api.Libreria.Core.Entities
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; }
        public BsonCollectionAttribute(string colleactionName)
        {
            CollectionName = colleactionName;
        }
    }
}
