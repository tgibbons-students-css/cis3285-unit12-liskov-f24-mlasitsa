using System;

namespace SubtypeCovariance
{
    public class Entity
    {
        public Entity(Guid newID)
        {
            ID = newID;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
