using System;

namespace SubtypeCovariance
{
    public class User : Entity
    {
        public User(Guid newID) : base(newID)
        {
            EmailAddress = "";
        }

        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
