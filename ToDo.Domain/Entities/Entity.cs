using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

        public bool Equals(Entity? other)
        {
            if (ReferenceEquals(null, other)) return false;
            return Id== other.Id;
        }
    }
}
