using System;

namespace Login.Entities.Entities.Auditories
{
    public class AuditableEntity: BaseEntity
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }
    }
}
