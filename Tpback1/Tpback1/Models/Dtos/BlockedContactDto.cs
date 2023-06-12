using System;

namespace Tpback1.Models.Dtos
{
    public class BlockedContactDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? CelularNumber { get; set; }
        public long? TelephoneNumber { get; set; }
        public string Description { get; set; }
        public int CallCount { get; set; }
        public DateTime TimeCall { get; set; }
    }
}
