using System;

namespace EfCorePoc.Api.Domain.Models
{
    public class Migration
    {
        public Guid MigrationId { get; set; }
        public DateTime StartedAt { get; set; }
        public string Observations { get; set; }
    }
}
